const clients2020 = ['Diego', 'Elizabeth', 'Michelle', 'Alfredo', 'Luis', 'Ximena'];
const clients2021 = ['Karen', 'Alexka', 'Katiuska', 'José', 'Pedro', 'Diego']

const globalClients =clients2020;

for (let index = 0; index < clients2021.length; index++) {
    const element = clients2021[index]
    globalClients.push(element)
}

console.log('For: ', globalClients);

// VS

const globalClientsConcat = clients2020.concat(clients2021);

console.log('Concat: ', globalClientsConcat)

