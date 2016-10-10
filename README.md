# DgtDataFileHelpers
Transforma los datos de matriculaciones, bajas y transferencias  proporcionados por la DGT en <a href="https://sedeapl.dgt.gob.es/WEB_IEST_CONSULTA/">su portal estadistico</a> (ficheros de texto con formato de campos de longitud fija) a un formato mas manejable (CSV, fichero de texto con campos separados por comas).

Uso:
<ol>
<li>
Descarga desde el portal estadistico de la DGT (https://sedeapl.dgt.gob.es/WEB_IEST_CONSULTA/) el fichero de microdatos que te interese y descomprimelo.
</li>
<li>
Descarga y descomprime esta utilidad desde el apartado "release"  <a href="https://github.com/jcaubin/DgtDataFileHelpers/releases/download/1.0/ConsoleDegtDataConverter.zip"> DgtDataConverter </a>
</li>
<li>
Abre una consola, situate en la carpeta en la que has descomprimido la utilidad y ejecútala utilizando el siguiente comando:
ConsoleDgtData -t tipoFichero [-m MARCA]  -f nombreFicheroMicrodatos
Donde: tipoFichero puede ser matriculaciones, bajas, transferencias. -m MARCA es un filtro opcional sobre el campo marca y nombreFichero es el nombre del fichero de microdatos
</li>
</ol>
Ejemplo:
Para procesar un fichero de bajas y quedarnos solo con las de la marca ALFA (Alfa Romeo)
ConsoleDgtData -t bajas -m ALFA  -f export_mensual_bajas_201608.txt 

El resultado es un fichero de texto con la extensión CVS que se puede abrir con Excel o similar para analizar los datos mas comodamente.


