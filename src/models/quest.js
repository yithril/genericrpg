let mongoose = require('mongoose');
let questSchema = require('./schemas/questSchema')

module.exports = mongoose.model('Quest', questSchema);