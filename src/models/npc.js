let mongoose = require('mongoose');
let NPCSchema = require('./schemas/npcSchema');

module.exports = mongoose.model('NPC', NPCSchema);