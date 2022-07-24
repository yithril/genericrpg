const express = require('express');
const app = express();
const cors = require('cors');

//Routes
const pc_routes = require('./src/routes/playerCharacterRoute.js');
const skill_routes = require('./src/routes/skillRoute.js');
const quest_routes = require('./src/routes/skillRoute.js');
const room_routes = require('./src/routes/roomRoute.js');
const item_routes = require('./src/routes/itemRoute.js');

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

mongoose.connect(process.env.MONGO_URI)
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
app.use('/api/Rooms', room_routes);
app.use('/api/Items', item_routes);

app.listen(process.env.PORT || 80);
console.log('Listening on ' + process.env.PORT || 80);