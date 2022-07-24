let mongoose = require('mongoose');
let skillSchema = require('./schemas/skillSchema');

module.exports = mongoose.model('Skill', skillSchema);