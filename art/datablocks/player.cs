//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//----------------------------------------------------------------------------
// Player Audio Profiles
//----------------------------------------------------------------------------
//================================================================
singleton SFXDescription( HumanAudio : player_footsteps) {
   id = 280;
};
//================================================================
datablock ParticleData(PlayerSplashMist)
{
   dragCoefficient      = 2.0;
   gravityCoefficient   = -0.05;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 400;
   lifetimeVarianceMS   = 100;
   useInvAlpha          = false;
   spinRandomMin        = -90.0;
   spinRandomMax        = 500.0;
   textureName          = "art/shapes/actors/common/splash";
   colors[0]     = "0.7 0.8 1.0 1.0";
   colors[1]     = "0.7 0.8 1.0 0.5";
   colors[2]     = "0.7 0.8 1.0 0.0";
   sizes[0]      = 0.5;
   sizes[1]      = 0.5;
   sizes[2]      = 0.8;
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(PlayerSplashMistEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 2.0;
   ejectionOffset   = 0.0;
   thetaMin         = 85;
   thetaMax         = 85;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   lifetimeMS       = 250;
   particles = "PlayerSplashMist";
};


datablock ParticleData(PlayerBubbleParticle)
{
   dragCoefficient      = 0.0;
   gravityCoefficient   = -0.50;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 400;
   lifetimeVarianceMS   = 100;
   useInvAlpha          = false;
   textureName          = "art/shapes/actors/common/splash";
   colors[0]     = "0.7 0.8 1.0 0.4";
   colors[1]     = "0.7 0.8 1.0 0.4";
   colors[2]     = "0.7 0.8 1.0 0.0";
   sizes[0]      = 0.1;
   sizes[1]      = 0.3;
   sizes[2]      = 0.3;
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(PlayerBubbleEmitter)
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 2.0;
   ejectionOffset   = 0.5;
   velocityVariance = 0.5;
   thetaMin         = 0;
   thetaMax         = 80;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "PlayerBubbleParticle";
};

datablock ParticleData(PlayerFoamParticle)
{
   dragCoefficient      = 2.0;
   gravityCoefficient   = -0.05;
   inheritedVelFactor   = 0.1;
   constantAcceleration = 0.0;
   lifetimeMS           = 600;
   lifetimeVarianceMS   = 100;
   useInvAlpha          = false;
   spinRandomMin        = -90.0;
   spinRandomMax        = 500.0;
   textureName          = "art/shapes/particles/millsplash01";
   colors[0]     = "0.7 0.8 1.0 0.20";
   colors[1]     = "0.7 0.8 1.0 0.20";
   colors[2]     = "0.7 0.8 1.0 0.00";
   sizes[0]      = 0.2;
   sizes[1]      = 0.4;
   sizes[2]      = 1.6;
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(PlayerFoamEmitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 85;
   thetaMax         = 85;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "PlayerFoamParticle";
};


datablock ParticleData( PlayerFoamDropletsParticle )
{
   dragCoefficient      = 1;
   gravityCoefficient   = 0.2;
   inheritedVelFactor   = 0.2;
   constantAcceleration = -0.0;
   lifetimeMS           = 600;
   lifetimeVarianceMS   = 0;
   textureName          = "art/shapes/actors/common/splash";
   colors[0]     = "0.7 0.8 1.0 1.0";
   colors[1]     = "0.7 0.8 1.0 0.5";
   colors[2]     = "0.7 0.8 1.0 0.0";
   sizes[0]      = 0.8;
   sizes[1]      = 0.3;
   sizes[2]      = 0.0;
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData( PlayerFoamDropletsEmitter )
{
   ejectionPeriodMS = 7;
   periodVarianceMS = 0;
   ejectionVelocity = 2;
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 60;
   thetaMax         = 80;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   orientParticles  = true;
   particles = "PlayerFoamDropletsParticle";
};

datablock ParticleData( PlayerWakeParticle )
{
   textureName          = "art/shapes/particles/wake";
   dragCoefficient     = "0.0";
   gravityCoefficient   = "0.0";
   inheritedVelFactor   = "0.0";
   lifetimeMS           = "2500";
   lifetimeVarianceMS   = "200";
   windCoefficient = "0.0";
   useInvAlpha = "1";
   spinRandomMin = "30.0";
   spinRandomMax = "30.0";

   animateTexture = true;
   framesPerSec = 1;
   animTexTiling = "2 1";
   animTexFrames = "0 1";

   colors[0]     = "1 1 1 0.1";
   colors[1]     = "1 1 1 0.7";
   colors[2]     = "1 1 1 0.3";
   colors[3]     = "0.5 0.5 0.5 0";

   sizes[0]      = "1.0";
   sizes[1]      = "2.0";
   sizes[2]      = "3.0";
   sizes[3]      = "3.5";

   times[0]      = "0.0";
   times[1]      = "0.25";
   times[2]      = "0.5";
   times[3]      = "1.0";
};

datablock ParticleEmitterData( PlayerWakeEmitter )
{
   ejectionPeriodMS = "200";
   periodVarianceMS = "10";

   ejectionVelocity = "0";
   velocityVariance = "0";

   ejectionOffset   = "0";

   thetaMin         = "89";
   thetaMax         = "90";

   phiReferenceVel  = "0";
   phiVariance      = "1";

   alignParticles = "1";
   alignDirection = "0 0 1";

   particles = "PlayerWakeParticle";
};

datablock ParticleData( PlayerSplashParticle )
{
   dragCoefficient      = 1;
   gravityCoefficient   = 0.2;
   inheritedVelFactor   = 0.2;
   constantAcceleration = -0.0;
   lifetimeMS           = 600;
   lifetimeVarianceMS   = 0;
   colors[0]     = "0.7 0.8 1.0 1.0";
   colors[1]     = "0.7 0.8 1.0 0.5";
   colors[2]     = "0.7 0.8 1.0 0.0";
   sizes[0]      = 0.5;
   sizes[1]      = 0.5;
   sizes[2]      = 0.5;
   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData( PlayerSplashEmitter )
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 3;
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 60;
   thetaMax         = 80;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   orientParticles  = true;
   lifetimeMS       = 100;
   particles = "PlayerSplashParticle";
};

datablock SplashData(PlayerSplash)
{
   numSegments = 15;
   ejectionFreq = 15;
   ejectionAngle = 40;
   ringLifetime = 0.5;
   lifetimeMS = 300;
   velocity = 4.0;
   startRadius = 0.0;
   acceleration = -3.0;
   texWrap = 5.0;

   texture = "art/shapes/particles/millsplash01";

   emitter[0] = PlayerSplashEmitter;
   emitter[1] = PlayerSplashMistEmitter;

   colors[0] = "0.7 0.8 1.0 0.0";
   colors[1] = "0.7 0.8 1.0 0.3";
   colors[2] = "0.7 0.8 1.0 0.7";
   colors[3] = "0.7 0.8 1.0 0.0";
   times[0] = 0.0;
   times[1] = 0.4;
   times[2] = 0.8;
   times[3] = 1.0;
};

//----------------------------------------------------------------------------
// Foot puffs
//----------------------------------------------------------------------------

datablock ParticleData(LightPuff)
{
   dragCoefficient      = 2.0;
   gravityCoefficient   = -0.01;
   inheritedVelFactor   = 0.6;
   constantAcceleration = 0.0;
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 100;
   useInvAlpha          = true;
   spinRandomMin        = -35.0;
   spinRandomMax        = 35.0;
   colors[0]     = "1.0 1.0 1.0 1.0";
   colors[1]     = "1.0 1.0 1.0 0.0";
   sizes[0]      = 0.1;
   sizes[1]      = 0.8;
   times[0]      = 0.3;
   times[1]      = 1.0;
};

datablock ParticleEmitterData(LightPuffEmitter)
{
   ejectionPeriodMS = 35;
   periodVarianceMS = 10;
   ejectionVelocity = 0.2;
   velocityVariance = 0.1;
   ejectionOffset   = 0.0;
   thetaMin         = 20;
   thetaMax         = 60;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   useEmitterColors = true;
   particles = "LightPuff";
};

//----------------------------------------------------------------------------
// Liftoff dust
//----------------------------------------------------------------------------

datablock ParticleData(LiftoffDust)
{
   dragCoefficient      = 1.0;
   gravityCoefficient   = -0.01;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 100;
   useInvAlpha          = true;
   spinRandomMin        = -90.0;
   spinRandomMax        = 500.0;
   colors[0]     = "1.0 1.0 1.0 1.0";
   sizes[0]      = 1.0;
   times[0]      = 1.0;
   textureName = "art/shapes/particles/dustParticle";
};

datablock ParticleEmitterData(LiftoffDustEmitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 2.0;
   velocityVariance = 0.0;
   ejectionOffset   = 0.0;
   thetaMin         = 90;
   thetaMax         = 90;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   useEmitterColors = true;
   particles = "LiftoffDust";
};

//----------------------------------------------------------------------------

datablock DecalData(PlayerFootprint)
{
   size = 0.4;
   material = CommonPlayerFootprint;
};

datablock DebrisData( PlayerDebris )
{
   explodeOnMaxBounce = false;

   elasticity = 0.15;
   friction = 0.5;

   lifetime = 4.0;
   lifetimeVariance = 0.0;

   minSpinSpeed = 40;
   maxSpinSpeed = 600;

   numBounces = 5;
   bounceVariance = 0;

   staticOnMaxBounce = true;
   gravModifier = 1.0;

   useRadiusMass = true;
   baseRadius = 1;

   velocity = 20.0;
   velocityVariance = 12.0;
};

// ----------------------------------------------------------------------------
// This is our default player datablock that all others will derive from.
// ----------------------------------------------------------------------------

datablock PlayerData(DefaultPlayerData)
{
   id = 3; //CM_REV

   renderFirstPerson = true;

   className = Armor;
   shapeFile = "art/Models/3D/Mobiles/Characters/male.dts";
   cameraMaxDist = 2.5;
   cameraMinDist = 0.8;
   cameraMaxDistWarStance = 2.5 + 1.2;
   cameraMinDistWarStance = 0.5;
   buildCameraMaxDist = 100;
   buildCameraMinDist = 5;
   buildScopeSize = 10;
   computeCRC = false;
   warstanceCamAngTheta = 0.4;
   peacestanceCamAngTheta = 0.0;

   canObserve = 1;
   cmdCategory = "Clients";

   cameraDefaultFov = 75; //100.0; //45;
   cameraMinFov = 5.0;
   cameraMaxFov = 120.0; //45;

   debrisShapeName = "art/shapes/actors/common/debris_player.dts";
   debris = playerDebris;

   aiAvoidThis = true;

   minLookAngle = -1.4;
   maxLookAngle =  1.4; //0.9;
   maxFreelookAngle = 3.0;

   lookupdown_animation_angle_min = -1.396; //80.0;
   lookupdown_animation_angle_max =  1.396; //80.0;

   mass = 100;
   drag = 1.3;
   maxdrag = 0.4;
   density = 1.1;
   maxDamage = 100;
   maxEnergy =  60;
   repairRate = 0.33;
   energyPerDamagePoint = 75;

   rechargeRate = 0.256;

   runForce = 4320;
   //runEnergyDrain = 0;
   //minRunEnergy = 0;

   rotSpeedFirstPersonStay = 0.22;
   rotSpeedFirstPersonMove = 0.12;
   rotSpeedThirdPersonStay = 0.2;
   rotSpeedThirdPersonMove = 0.12;
   rotSpeedRotationAnim = 0.32;

   maxForwardSpeed = 4;
   maxBackwardSpeed = 3;
   maxSideSpeed = 3;
   maxRuningSpeed = 8;

   maxWarForwardSpeed = 4;
   maxWarBackwardSpeed = 2.5;
   maxWarSideSpeed = 4.5;
   maxWarRuningSpeed = 8;

   crouchForce = 405;
   maxCrouchForwardSpeed = 4.0;
   maxCrouchBackwardSpeed = 2.0;
   maxCrouchSideSpeed = 2.0;

   equipDrownCoeff = 0.000000000000000000035;
   waterStaminaRate = 0.0000000000000000008; // per second
   oxygenRate = .00000000000000000000000000000000000005; // per second

   maxUnderwaterForwardSpeed = 4;//8.4;
   maxUnderwaterBackwardSpeed = 3;//7.8;
   maxUnderwaterSideSpeed = 3;// 7.8;

   jumpForce = 900;
   pounceForce = 1200;
   //jumpEnergyDrain = 0;
   //minJumpEnergy = 0;
   jumpDelay = 15;
   airControl = 0.01;

   recoverDelay = 9;
   recoverRunForceScale = 1.2;

   minImpactSpeed = 15;
   impactGroundSpeed = 45;
   speedDamageScale = 0.4;

   //CM_CHANGE
   //boundingBox = "1 1 2";
   //swimBoundingBox = "1 2 2";
   //pickupRadius = 0.75;
   boundingBox = "1.5 1 3.5";
   crouchBoundingBox = "1.5 1 3";
   swimBoundingBox = "1 2 2";
   standardRaycastBox = "4.244 4.747 4.246";
   mountingRaycastBox = "4.691 11.666 5.425";
   pickupRadius = 1;

   // Damage location details
   boxNormalHeadPercentage       = 0.83;  //not in use
   boxNormalTorsoPercentage      = 0.49;  //not in use
   boxHeadLeftPercentage         = 0;     //not in use
   boxHeadRightPercentage        = 1;     //not in use
   boxHeadBackPercentage         = 0;     //not in use
   boxHeadFrontPercentage        = 1;     //not in use

   footPuffEmitter = LightPuffEmitter;
   footPuffNumParts = 10;
   footPuffRadius = 0.25;

   dustEmitter = LiftoffDustEmitter; //LightPuffEmitter

   splash = PlayerSplash;
   splashVelocity = 4.0;
   splashAngle = 67.0;
   splashFreqMod = 300.0;
   splashVelEpsilon = 0.60;
   bubbleEmitTime = 0.4;
   splashEmitter[0] = PlayerWakeEmitter;
   splashEmitter[1] = PlayerFoamEmitter;
   splashEmitter[2] = PlayerBubbleEmitter;
   mediumSplashSoundVelocity = 10.0;
   hardSplashSoundVelocity = 20.0;
   exitSplashSoundVelocity = 5.0;

   knockedDownTicks = 1;

   // Controls over slope of runnable/jumpable surfaces
   runSurfaceAngle  = 46;//70;//38;
   jumpSurfaceAngle = 80;
   maxStepHeight = 0.5;//1.5;  //two meters
   minJumpSpeed = 20;
   maxJumpSpeed = 30;

   horizMaxSpeed = 68;
   horizResistSpeed = 33;
   horizResistFactor = 0.35;

   upMaxSpeed = 80;
   upResistSpeed = 25;
   upResistFactor = 0.3;

   footstepSplashHeight = 0.35;

   // Footstep Sounds
   // steps & sounds
   stepSoundsDir             = "art/sound/human/";
   stepSoundsGeneralName     = "footstep_human";
   stepSoundsStartingId      = "281";
   stepSoundsDescription     = "HumanAudio";

   moveSoundsDir             = "art/sound/human/";
   moveSoundsGeneralName     = "player";
   moveSoundsStartingId      = "300";
   moveSoundsDescription     = "HumanAudio";

   DecalData                 = PlayerFootprint;
   decalOffset               = 0.25;

   footNodeName1             = "Bip01 L Toe0";
   footNodeName2             = "Bip01 R Toe0";

   groundImpactMinSpeed    = 100.0; //45
   groundImpactShakeFreq   = "4.0 4.0 4.0";
   groundImpactShakeAmp    = "1.0 1.0 1.0";
   groundImpactShakeDuration = 0.8;
   groundImpactShakeFalloff = 10.0;

   observeParameters = "0.5 4.5 4.5";

   // Allowable Inventory Items
   mainWeapon = SwordWeapon; //GrenadeLauncher;

   class = "armor";

   //cameraMinDist = "0";
   //DecalData = "PlayerFootprint";

   //bloodEmitterTypeName = "BloodEmitterLiF2Z";
   //bloodEmitterDuration = 20;
};

datablock PlayerData( PlayerMaleData : DefaultPlayerData) {
   id = 400;
   shapeFile = "art/Models/3D/Mobiles/Characters/male.dts";
   nakedPlayerBloodTexturesDir = "art/Textures/CharacterTextures/Blood/Male/";
   armorBloodTexturesDir = "art/Textures/CharacterTextures/Blood/Armor/";
   horseScale = "0.892 0.892 0.892";
   shapeScale = "0.892 0.892 0.892";
};

datablock PlayerData( PlayerFemaleData : DefaultPlayerData) {
   id = 401;
   shapeFile = "art/Models/3D/Mobiles/Characters/female.dts";
   nakedPlayerBloodTexturesDir = "art/Textures/CharacterTextures/Blood/Female/";
   armorBloodTexturesDir = "art/Textures/CharacterTextures/Blood/Armor/";
   imageScale = "1 1 1";
   horseScale = "0.892 0.892 0.892";
   shapeScale = "0.892 0.892 0.892";
};

datablock CameraData(Observer)
{
   id = 139;
   mode = "Observer";
   useEyePoint = true;
   firstPersonOnly = true;
};

datablock PathCameraData(PathCamData)
{
   id = 356;
   useEyePoint = true;
   firstPersonOnly = true;
};
