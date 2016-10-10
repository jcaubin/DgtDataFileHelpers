# DgtDataFileHelpers
Transforma los datos de matriculaciones, bajas y transferenecias  proporcionados por la DGT en su portal estadistico (ficheros de texto de longitudes fijas) 
a un formato mas manejable (CSV).

Uso:
1. Descarga desde el portal estadistico de la DGT (https://sedeapl.dgt.gob.es/WEB_IEST_CONSULTA/) el fichero de microdatos que te interese y descomprimelo.
2. Descarga y descomprime esta utilidad desde el apartado "release" (https://github.com/jcaubin/DgtDataFileHelpers/releases/download/1.0/ConsoleDegtDataConverter.zip)
2. Abre una consola, situate en la carpeta en la que has descomprimido la utilidad y ejecútala utilizando el siguiente comando:
ConsoleDgtData -t tipoFichero [-m MARCA]  -f nombreFicheroMicrodatos
Donde: tipoFichero puede ser matriculaciones, bajas, transferencias. -m MARCA es un filtro opcional sobre el campo marca y nombreFichero es el nombre del fichero de microdatos

Ejemplo:
Para procesar un fichero de bajas y quedarnos solo con las de la marca ALFA (Alfa Romeo)
ConsoleDgtData -t bajas -m ALFA  -f export_mensual_bajas_201608.txt 

El resultado es un fichero de texto con la extensión CVS que se puede abrir con Excel o similar para analizar los datos mas comodamente.


