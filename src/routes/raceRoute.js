const express = require('express');
const router = express.Router();
const { auth, requiredScopes } = require('express-oauth2-jwt-bearer');
const checkJwt = auth({
    audience: 'https://genericrpg/api',
    issuerBaseURL: `https://dev-va9l1-67.us.auth0.com/`,
  });

  const {
    getRaces,
    getRace,
    createRace,
    updateRace,
    deleteRace,
} = require('../controllers/RaceController');

router.route('/').get([checkJwt], getRaces);

router.route('/:id').get([checkJwt], getRace);

router.route('/').post([checkJwt], createRace);

router.route('/:id').put([checkJwt], updateRace);

router.route('/:id').delete([checkJwt], deleteRace);

module.exports = router;

  