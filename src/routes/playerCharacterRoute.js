const express = require('express');
const router = express.Router();
const { auth, requiredScopes } = require('express-oauth2-jwt-bearer');
const checkJwt = auth({
    audience: 'https://genericrpg/api',
    issuerBaseURL: `https://dev-va9l1-67.us.auth0.com/`,
  });

const {
    getPlayerCharacters,
    getPlayerCharacter,
    createPlayerCharacter,
    updatePlayerCharacter,
    deletePlayerCharacter
} = require('../controllers/playerCharacterController');

router.route('/').get([checkJwt], getPlayerCharacters);

router.route('/:id').get([checkJwt], getPlayerCharacter);

router.route('/').post([checkJwt], createPlayerCharacter);

router.route('/:id').put([checkJwt], updatePlayerCharacter);

router.route('/:id').delete([checkJwt], deletePlayerCharacter);

module.exports = router;
