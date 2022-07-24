let mongoose = require('mongoose');
let characterSchema = require('./schemas/playerSchema');

module.exports = mongoose.model('Character', characterSchema);