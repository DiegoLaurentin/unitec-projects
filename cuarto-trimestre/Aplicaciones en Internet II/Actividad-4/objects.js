// Objetos en Javascript

const Diego = {
    nombre: 'Diego Laurentin',
    edad: 18,
    trimestre: 4,
    materias: [
        'Programacion III',
        'Aplicaciones en Internet II',
    ],
    nuevaMateria(materia) {
        this.materias.push(materia)
    }
}

// -----------------------------------------------

function Estudiante(nombre, edad, materias) {
    this.nombre = nombre
    this.edad = edad
    this.materias = materias
}

Estudiante.prototype.nuevaMateria = function(materia) {
    this.materias.push(materia)
}

const Alberto = new Estudiante(
    'Alberto',
    26,
    [
        'Ingenieria Industrial',
        'Dibujo Tecnico',
    ]
)