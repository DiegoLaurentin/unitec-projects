// Clases con JavaScript

class Estudiante {
    constructor(nombre, edad, cedula, email, trimestre, materias) {
       this.nombre = nombre
       this.edad = edad
       this.cedula = cedula
       this.email = email
       this.trimestre = trimestre
       this.materias = materias 
    }

    nuevaMateria(materia) {
        this.materias.push(materia)
    }

    trimestreAprobado() {
        ++this.trimestre
    }
}

class Profesor{
    constructor(nombre, edad, cedula, email, trimestre, materias, telefono, sueldo) {
        this.nombre = nombre
        this.edad = edad
        this.cedula = cedula
        this.email = email
        this.trimestre = trimestre
        this.materias = materias
        this.telefono = telefono
        this.sueldo = sueldo
    }

    nuevaMateria(materia) {
        this.materias.push(materia)
    }

    aumentoSueldo(aumento) {
        this.sueldo += aumento
    }
}

// Creando Objetos mediante Clases

const DiegoLaurentin = new Estudiante(
    'Diego Laurentin',
    18,
    30096907,
    'diego.laurentin.ac@gmail.com',
    4,
    ['programacion III']
)


const Jose = new Profesor(
    'Jose Enrique',
    28,
    12367561,
    'joseenrique@gmail.com',
    5,
    ['estadistica'],
    042446577,
    300
)