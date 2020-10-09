/* Script de creación de la nueva tabla SeRelaciona (para relacionar Sintomas con Auto_Diagnostico) */


/* Forma 1 */
create table SeRelaciona(
  idAutodiagnostico int(10) NOT NULL AUTO_INCREMENT,
  nombresSintoma varchar(100) NOT NULL,
  KEY idAutodiagnostico (idAutodiagnostico),
  KEY nombresSintoma (nombresSintoma),
  
  CONSTRAINT SeRelaciona_ibfk_1 FOREIGN KEY (idAutodiagnostico) REFERENCES Auto_Diagnostico(idAutodiagnostico),
  
  CONSTRAINT SeRelaciona_ibfk_2 FOREIGN KEY (nombresSintoma) REFERENCES Sintoma(nombresSintoma) 
);

/* Forma 2 */
create table SeRelaciona(
  idAutodiagnostico int(10) NOT NULL AUTO_INCREMENT,
  nombresSintoma varchar(100) NOT NULL,
  PRIMARY KEY (idAutodiagnostico, nombresSintoma),
  FOREIGN KEY idAutodiagnostico REFERENCES Auto_Diagnostico(idAutodiagnostico),
  FOREIGN KEY nombresSintoma REFERENCES Sintoma(nombresSintoma)
);

