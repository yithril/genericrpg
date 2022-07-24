let mongoose = require('mongoose');
let raceSchema = require('./schemas/raceSchema');

module.exports = mongoose.model('Race', raceSchema);