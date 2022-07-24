let options = { discriminatorKey: 'item' };
let mongoose = require('mongoose');

let weaponSchema = mongoose.Schema({
    damageConstant: Number,
    diceNumber: Number,
    diceSide: Number,
    damageType:{
        type: String,
        enum: ['fire', 'slashing', 'piercing', 'crushing', 'ice', 'lightning', 'acid', 'psychic', 'necromantic', 'holy', 'order', 'chaos']
    },
    size: {
        type: String,
        enum: ['tiny', 'small', 'medium', 'large', 'huge']
    }
},{
    options
});

module.exports = weaponSchema;