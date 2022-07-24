let options = { discriminatorKey: 'item' };
let mongoose = require('mongoose');
let Limb = require('./limbSchema');

let armorSchema = mongoose.Schema({
    durability: Number,
    limbs: [Limb],
    size: {
        type: String,
        enum: ['tiny', 'small', 'medium', 'large', 'huge']
    },
    resistType:{
        type: String,
        enum: ['none', 'fire', 'slashing', 'piercing', 'crushing', 'ice', 'lightning', 'acid', 'psychic', 'necromantic', 'holy', 'order', 'chaos']
    },
    AC: Number
},{
    options
});

module.exports = armorSchema;