#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>
#include <mysql.h>

#define port 35678

#define id_max_length 10
#define email_max_length 50
#define username_max_length 20
#define password_max_length 20

#define email_min_length 4
#define username_min_length 4
#define password_min_length 4

#define sql_query_max_length 1024
#define read_buffer_length 512
#define write_buffer_length 512

#define database_name "bd"
#define database_username "root"
#define database_password "mysql"
#define database_host "localhost"

int dime_si_usuario_y_contra_son_correctas(char nombre_usuario[username_max_length],char password[password_max_length], MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char str_query[sql_query_max_length];
	sprintf(str_query, "SELECT Contrasenya FROM jugador WHERE Username='%s' AND Contrasenya = '%s'", nombre_usuario, password);
	if (mysql_query(conn, str_query) != 0) {
		
		printf("Error al ejecutar la consulta: %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0;
	}
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	
	if (row == NULL)
		return 0; // Contraseña o usuario no son correctas.
	else
		return 1; // Contraseña y usuario son correctas.
}

int dime_si_usuario_existe(char nombre_usuario[username_max_length], MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char str_query[sql_query_max_length];
	sprintf(str_query, "SELECT Username FROM jugador WHERE Username='%s'", nombre_usuario);
	if (mysql_query(conn, str_query) != 0) {
		
		printf("Error al ejecutar la consulta: %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0;
	}
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	
	if (row == NULL)
		return 0; // Usuario no existe.
	else
		return 1; // Usuario existe.
}
int dime_si_correo_existe(char correo[email_max_length], MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char str_query[sql_query_max_length];
	sprintf(str_query, "SELECT Correo FROM jugador WHERE Correo='%s'", correo);
	if (mysql_query(conn, str_query) != 0) {
		
		printf("Error al ejecutar la consulta: %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0;
	}
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	
	if (row == NULL)
		return 0; // Correo no existe.
	else
		return 1; // Correo existe.
}
int obtener_id_ultimo_usuario(MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char str_query[sql_query_max_length];
	sprintf(str_query, "SELECT MAX(ID) FROM jugador");
	if (mysql_query(conn, str_query) != 0) {
		
		printf("Error al ejecutar la consulta: %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0;
	}
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	
	if (row == NULL)
		return 0; // No hay jugadores.
	else
		return atoi(row[0]); // Máximo.
}
int anadir_usario_a_la_base_de_datos(char nombre_usuario[username_max_length],char contrasena[password_max_length], char email[email_max_length], char fecha[10], MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char str_query[sql_query_max_length];
	char id[id_max_length];
	sprintf(id, "%d",obtener_id_ultimo_usuario(conn)+1);
	if ((dime_si_usuario_existe(nombre_usuario,conn)  == 0) && (dime_si_correo_existe(email, conn) == 0) ) {
		sprintf(str_query, "INSERT INTO jugador VALUES ('%s','%s','%s','%s','%s')",id, nombre_usuario,email,contrasena,fecha);
		
		if (mysql_query(conn, str_query) != 0) {
			printf("Error al ejecutar la consulta: %u %s\n", mysql_errno(conn), mysql_error(conn));
			return 0;
		}
		else {
			return 1;
		}
	}
	else {
		printf("El correo electronico o el nombre de usuario ya existen.");
		return 0;
	}
	
}

int numero_de_partidas_jugadas_en_X_intervalo_de_tiempo(char dia1[10], char dia2[10], MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char str_query[sql_query_max_length];
	sprintf(str_query, "SELECT COUNT(IDPartida) FROM partidas WHERE FechayHoraFinal>='%s 00:00:00' AND FechayHoraFinal < '%s 00:00:00'", dia1, dia2);
	if (mysql_query(conn, str_query) != 0) {
		
		printf("Error al ejecutar la consulta: %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0;
	}
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	
	return atoi(row[0]);
}

int cuenta_cantidad_de_usuarios(MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char consulta[sql_query_max_length];
	strcpy(consulta, "SELECT COUNT(Username) FROM jugador");
		
	if (mysql_query (conn, consulta) != 0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		return -1;
	}
	
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	return atoi(row[0]);
}

void dame_todos_los_usuarios(char usuarios[90000]  , MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char consulta[sql_query_max_length];
	strcpy(consulta, "SELECT Username FROM jugador");
	if (mysql_query (conn, consulta) != 0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	
	while (row !=NULL ) {
		strcat(usuarios,row[0]);
		strcat(usuarios,"-");
		row = mysql_fetch_row(result);
	}
	usuarios[strlen(usuarios)-1] = '\0';
	printf("%s", usuarios);
}

float dame_tiempo_medio_partidas_jugador(char usuario[username_max_length], MYSQL *conn) {
	MYSQL_RES *result;
	MYSQL_ROW row;
	char consulta[sql_query_max_length];
	
	strcpy(consulta, "SELECT AVG(partidas.Duracion) FROM (jugador, partidas, RelacionIDsPartidas) WHERE jugador.USERNAME = '");
	strcat(consulta, usuario);
	strcat(consulta, "' AND jugador.ID = RelacionIDsPartidas.IDJugador AND (RelacionIDsPartidas.IDEquipo = partidas.IDEquipo1 OR RelacionIDsPartidas.IDEquipo = partidas.IDEquipo2) ");
	
	if (mysql_query (conn, consulta) != 0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0.0;
		exit(1);
	}
	result = mysql_store_result(conn);
	row = mysql_fetch_row(result);
	if (row[0] == NULL) {
		return 0.0;
	}
	return atof(row[0]);

	
}

int devuelvaPartidasGanadas(char usuario[username_max_length], MYSQL *conn)
{
	
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	int victorias = 0;
	char consulta[sql_query_max_length];
	strcpy(consulta,"SELECT partidas.Resultado,RelacionIDsPartidas.IDEquipo,partidas.IDEquipo1,partidas.IDEquipo2 FROM (RelacionIDsPartidas,jugador,partidas) WHERE jugador.USERNAME = '");
	strcat(consulta,usuario);
	strcat(consulta, "' AND jugador.ID = RelacionIDsPartidas.IDJugador AND RelacionIDsPartidas.IDPartida = partidas.IDPartida");
	if (mysql_query (conn, consulta)!=0) 
	{
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		return 0;
		exit(1);
	}
	
	resultado = mysql_store_result(conn); 
	row = mysql_fetch_row(resultado);
	if (row == NULL) {
		
		return 0;
	}
	else {
	
	while(row != NULL)
	{
		
		if ((atoi(row[1]) == atoi(row[2]) && atoi(row[0]) == 0) || (atoi(row[1]) == atoi(row[3]) && atoi(row[0]) == 1) )   //we supose that if the tinyint is 0 team1 wins, if 1 otherwise
			victorias = victorias + 1;
		row = mysql_fetch_row (resultado);
	}
	
	
	
	// cerrar la conexion con el servidor MYSQL 
	
	return victorias; 
	}// We return the value obtained 
}	
void *AtenderCliente (void *socket){
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn = *s;
	char peticion[read_buffer_length];
	char respuesta[write_buffer_length];
	int ret;
	int terminar =0;
	while  (terminar == 0){
		
	
	ret = read(sock_conn,peticion,sizeof(peticion));
	printf("Recibido");
	peticion[ret]='\0';
	
	printf("Peticion: %s\n",peticion);
	
	char *p = strtok (peticion, "/");
	int codigo = atoi(p);
	
	char nombre_usuario[username_max_length];
	
	
	char contrasena[password_max_length];
	char correo[email_max_length];
	char fecha[10];
	char dia1[10];
	char dia2[10];
	MYSQL *conn;
	conn = mysql_init(NULL);
	if (conn == NULL) {
		printf("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	conn = mysql_real_connect(conn, database_host, database_username, database_password, database_name, 0, NULL, 0);
	
	if (conn == NULL) {
		
		printf("Error conectando: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit(1);
		
	}
	if (codigo==1) {
		p = strtok(NULL,"/");
		strcpy(nombre_usuario,p);
		
		p = strtok(NULL,"/");
		strcpy(contrasena,p);
		printf ("Codigo: %d, Nombre: %s Contra: %s \n", codigo, nombre_usuario,contrasena);
		
		
		
		int valor = dime_si_usuario_y_contra_son_correctas(nombre_usuario, contrasena, conn);
		
		
		
		
		
		if (valor == 1)
			strcpy(respuesta,"Login");
		else 
			strcpy(respuesta,"Permiso denegado");
		write(sock_conn,respuesta,strlen(respuesta));
		
		
	} 
	
	else if (codigo == 2) {
		p = strtok(NULL,"/");
		strcpy(dia1,p);
		
		p = strtok(NULL,"/");
		strcpy(dia2,p);
		printf ("Codigo: %d, Dia 1: %s Dia2: %s \n", codigo, dia1,dia2);
		
		
		int value =  numero_de_partidas_jugadas_en_X_intervalo_de_tiempo(dia1, dia2, conn);
		
		
		sprintf(respuesta,"%d",value);
		write(sock_conn,respuesta,strlen(respuesta));
		
	}
	
	else if (codigo == 3) {
		p = strtok(NULL,"/");
		strcpy(nombre_usuario,p);
		
		p = strtok(NULL,"/");
		strcpy(contrasena,p);
		p = strtok(NULL,"/");
		strcpy(correo,p);
		p = strtok(NULL,"/");
		strcpy(fecha,p);
		printf ("Codigo: %d, Usuario: %s Contra: %s Correo: %s Fecha: %s \n", codigo, nombre_usuario,contrasena, correo, fecha);
		
		
		int registro = anadir_usario_a_la_base_de_datos(nombre_usuario,contrasena,correo,fecha,conn);
		
		
		if (registro == 1)
			sprintf(respuesta,"Registro");
		else {
			if ((dime_si_usuario_existe(nombre_usuario,conn)  == 1))
				sprintf(respuesta,"Usuario existente");
			else if (dime_si_correo_existe(correo,conn)  == 1)
				sprintf(respuesta,"Correo existente");
			
			
		}
		write(sock_conn,respuesta,strlen(respuesta));
		
	}
	else if (codigo == 4) {
		char nombre_usuario_average[username_max_length];
		p = strtok(NULL,"/");
		strcpy(nombre_usuario_average,p);
		sprintf(respuesta,"%f",dame_tiempo_medio_partidas_jugador(nombre_usuario_average, conn));
		write(sock_conn,respuesta,strlen(respuesta));
		
		
		
		
		
	}
	else if (codigo == 5) {
		char nombre_usuario_ganadas[username_max_length];
		p = strtok(NULL,"/");
		strcpy(nombre_usuario_ganadas,p);
		sprintf(respuesta,"%d",devuelvaPartidasGanadas(nombre_usuario_ganadas, conn));
		write(sock_conn,respuesta,strlen(respuesta));
		
		
		
	}
	else if (codigo == 6) 
	{
		
		char todos[90000];
		dame_todos_los_usuarios(todos,conn);
		
		strcpy(respuesta,todos);
		write(sock_conn,respuesta,strlen(respuesta));
	}
	}
	mysql_close(conn);		
	close(sock_conn);
	
	
	
}
int main(int argc, char *argv[]) {
	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	memset(&serv_adr, 0, sizeof(serv_adr));
 	serv_adr.sin_family = AF_INET;
 	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); 
 	serv_adr.sin_port = htons(port);
	
 	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf("Error al bind");
	if (listen(sock_listen, 5) < 0)
		printf("Error en el Listen");
	int i;
	int sockets[100];
	i = 0;
	pthread_t thread;
	for(;;){
		printf("Escuchando\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("Conexion recibida\n");
		sockets[i] = sock_conn;
		pthread_create(&thread, NULL, AtenderCliente, &sockets[i]);
		i = i + 1;
		
	}
	return 0;

}
