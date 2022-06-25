let mongoose = require('mongoose');

const server = '';
const databse = '';

class Database{
    constructor(){
        this._connect();
    }

    _connect(){
        mongoose.connect('mongodb://')
        .then(() => {
            console.log('Database connection successful')
        })
        .catch(err => {
            console.log('Database error: ' + err);
        });
    }
}

module.exports = new Database();