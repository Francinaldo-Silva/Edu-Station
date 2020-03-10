const Sequelize = require('sequelize')
const sequelize = new Sequelize('edu_station', 'root', 'Tecnico@19900%', { host: "localhost", dialect: 'mysql' })
sequelize.authenticate().then(function () {
    console.log("Sucesso")
}).catch(function (erro) {
    console.log("Falha"+erro)
})