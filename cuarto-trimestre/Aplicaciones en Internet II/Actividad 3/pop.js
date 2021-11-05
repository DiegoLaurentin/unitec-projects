const list = ['Harina de Trigo', 'Harina Pan', 'Azúcar', 'Sal', 'Baterías', 'Carne', 'Pollo']

let newList = [];

for (let index = 0; index < (list.length - 1) ; index++) {
    const element = list[index]
    
    newList.push(element);
}

console.log(newList);

// VS

var ultimo = list.pop('Pollo')
console.log(list)

var ultimo2 = list.pop('Sal');

console.log(list)