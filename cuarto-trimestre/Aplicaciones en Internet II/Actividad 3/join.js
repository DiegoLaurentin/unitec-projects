const elements = ['Fire', 'Air', 'Water', 'Earth']

let finalAnswer = '';
const separator = '--';

// for (let index = 0; index < elements.length; index++) {
//     const element = elements[index]

//     finalAnswer = finalAnswer + element + separator;
// }

for (let index = 0; index < elements.length; index++) {
    const element = elements[index]
    if (index === elements.length -1) {
        finalAnswer = finalAnswer + element;
    } else {
        finalAnswer = finalAnswer + element + separator;
    }
}

console.log('for: ', finalAnswer)

// Ejemplo = Creador de url para la universidad

const ipUniversity = 'https://aulavirtual.unitec.edu.ve/';

var input = 'Aplicaciones en Internet II'; // -> Arreglo / Array

const urlFinal = (ipUniversity + input.split(' ').join('-').toLocaleLowerCase())

console.log('url: ', urlFinal)