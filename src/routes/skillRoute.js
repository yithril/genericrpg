const express = require('express');
const router = express.Router();
const { auth, requiredScopes } = require('express-oauth2-jwt-bearer');
const checkJwt = auth({
    audience: 'https://genericrpg/api',
    issuerBaseURL: `https://dev-va9l1-67.us.auth0.com/`,
  });

  const {
    getSkills,
    getSkill,
    createSkill,
    updateSkill,
    deleteSkill,
} = require('../controllers/skillController');

router.route('/').get([checkJwt], getSkills);

router.route('/:id').get([checkJwt], getSkill);

router.route('/').post([checkJwt], createSkill);

router.route('/:id').put([checkJwt], updateSkill);

router.route('/:id').delete([checkJwt], deleteSkill);

module.exports = router;

  