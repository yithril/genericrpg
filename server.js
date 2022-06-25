const express = require('express');
const app = express();
const cors = require('cors');

//Routes
const pc_routes = require('./src/routes/playerCharacterRoute');
const skill_routes = require('./src/routes/skillRoute');
const quest_routes = require('./src/routes/questRoute');


const mongoose = require('mongoose');
const bParser = require('body-parser');
const bodyParser = require('body-parser');

require('dotenv').config();

if (!process.env.ISSUER_BASE_URL || !process.env.AUDIENCE) {
  throw 'Make sure you have ISSUER_BASE_URL, and AUDIENCE in your .env file';
}

const corsOptions =  {
  origin: 'http://localhost:3000'
};

mongoose.connect('mongodb+srv://genericrpguser:GwhjBBgr5lkDjIKi@cluster0.fvyrw.mongodb.net/?retryWrites=true&w=majority')
.then(() => {
  console.log('Database connected');
})
.catch((error) => {
  console.log('Error connecting: ' + error);
});

app.use(cors(corsOptions));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

app.use(function(err, req, res, next){
  console.error(err.stack);
  return res.set(err.headers).status(err.status).json({ message: err.message });
});

app.use('/api/playerCharacters', pc_routes);
app.use('/api/Skills', skill_routes);
app.use('/api/Quests', quest_routes);

app.listen(3010);
console.log('Listening on http://localhost:3010');
