//  Attack types:
// Attack1H
// Attack2HSword
// Attack2HWeapon_spear
// AttackPike
// Attack1_2HSword
// AttackBow
// AttackCrossbow
// AttackThrowing

//  Weapon types:
// Weapon1_2HSword
// Weapon1HAxe
// Weapon1HMace
// Weapon1HSword
// Weapon2HAxe
// Weapon2HMace
// Weapon2HSword
// WeaponBow
// WeaponCrossbow
// WeaponLance
// WeaponPike
// WeaponPolearm
// WeaponSpear
// WeaponThrowing
// WeaponShield
// WeaponMisc

//  hitGroup types:
// Slashing
// Piercing
// Blunt

datablock ShapeBaseImageData(PracticeSword)
{
   id = 4;
   Object_typeID = 555;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/Practice_Sword/Practice_Sword_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeSwordItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(NordicSword)
{
   id = 5;
   Object_typeID = 556;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/NordicSword/Nordic_Sword_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 5.0;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.7;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = NordicSwordItem;
   BasePrefireAnimTime =1;
   BaseFireAnimTime = 1;
   BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(KnightSword)
{
   id = 6;
   Object_typeID = 557;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/KnightSword/Knight_Sword_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 5.0;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KnightSwordItem;
BasePrefireAnimTime = 1.2;
BaseFireAnimTime = 1.2;
BaseRecoilAnimTime = 1.4;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(LightSaber)
{
   id = 7;
   Object_typeID = 558;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/LightSaber/Light_Saber_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.2;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 0.4;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = LightSaberItem;
BasePrefireAnimTime =0.8;
BaseFireAnimTime = 0.8;
BaseRecoilAnimTime = 0.5;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Scimitar)
{
   id = 8;
   Object_typeID = 559;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/Scimitar/Scimitar_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.1;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.4;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ScimitarItem;
BasePrefireAnimTime =1.2;
BaseFireAnimTime = 1.1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Falchion)
{
   id = 9;
   Object_typeID = 560;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/Falchion/Falchion_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.5;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.4;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 1.6;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = FalchionItem;
BasePrefireAnimTime =1.5;
BaseFireAnimTime = 0.85;
BaseRecoilAnimTime = 1.9;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(PracticeBastard)
{
   id = 10;
   Object_typeID = 561;
   
   shapefile = "art/Models/3D-2D/Weapons/1-2Hswords/Practice_Bastard_Sword/Practice_Bastard_Sword_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.6;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeBastardItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Estoc)
{
   id = 11;
   Object_typeID = 562;
   
   shapefile = "art/Models/3D-2D/Weapons/1-2Hswords/Estoc/Estoc_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.5;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.5;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = EstocItem;
BasePrefireAnimTime =0.7;
BaseFireAnimTime = 0.8;
BaseRecoilAnimTime = 0.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(BastardSword)
{
   id = 12;
   Object_typeID = 563;
   
   shapefile = "art/Models/3D-2D/Weapons/1-2Hswords/Bastard/bastard.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.3;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.0;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BastardSwordItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(BigFalchion)
{
   id = 13;
   Object_typeID = 564;
   
   shapefile = "art/Models/3D-2D/Weapons/1-2Hswords/BigFalchion/Big_Falchion_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.5;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 3.2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 1.6;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BigFalchionItem;
BasePrefireAnimTime =1.2;
BaseFireAnimTime = 1.1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(GrossMesser)
{
   id = 14;
   Object_typeID = 565;
   
   shapefile = "art/Models/3D-2D/Weapons/1HSwords/GrossMesser/GrossMesser_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.9;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.9;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = GrossMesserItem;
BasePrefireAnimTime =1.2;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 0.9;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(PracticeAxe)
{
   id = 15;
   Object_typeID = 566;
   
   shapefile = "art/Models/3D-2D/Weapons/1HAxes/Practice_Axe/Practice_Axe_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeAxeItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(WarAxe)
{
   id = 16;
   Object_typeID = 567;
   
   shapefile = "art/Models/3D-2D/Weapons/1HAxes/waraxe/WarAxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.3;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.6;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 3.6;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarAxeItem;
BasePrefireAnimTime =1.2;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(BattleAxe)
{
   id = 17;
   Object_typeID = 568;
   
   shapefile = "art/Models/3D-2D/Weapons/1HAxes/battleaxe/BattleAxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.6;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1.8;
   FractureMultiplier = 2.6;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BattleAxeItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1.4;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(NordicAxe)
{
   id = 18;
   Object_typeID = 569;
   
   shapefile = "art/Models/3D-2D/Weapons/1HAxes/NordicAxe/NordicAxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.5;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.6;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1.5;
   FractureMultiplier = 2.4;
   StunMultiplier = 0.15;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = NordicAxeItem;
BasePrefireAnimTime =1.5;
BaseFireAnimTime = 0.7;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(MorningStar)
{
   id = 19;
   Object_typeID = 570;
   
   shapefile = "art/Models/3D-2D/Weapons/1HMaces/Morningstar/MorningStar.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.4;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[1] = 1.7;
   hitGroupType[2] = Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 1.9;
   StunMultiplier = 0.6;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MorningStarItem;
BasePrefireAnimTime =1.3;
BaseFireAnimTime = 1.2;
BaseRecoilAnimTime = 1.3;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(FlangedMace)
{
   id = 20;
   Object_typeID = 571;
   
   shapefile = "art/Models/3D-2D/Weapons/1HMaces/flangedmace/FlangedMace.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.4;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.1;
   FractureMultiplier = 2;
   StunMultiplier = 0.9;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = FlangedMaceItem;
BasePrefireAnimTime =1.3;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1.2;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Cudgel)
{
   id = 21;
   Object_typeID = 572;
   
   shapefile = "art/Models/3D-2D/Weapons/1HMaces/Cudgel/Cudgel.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 2.3;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 1.5;
   StunMultiplier = 1.7;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = CudgelItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(WarPick)
{
   id = 22;
   Object_typeID = 573;
   
   shapefile = "art/Models/3D-2D/Weapons/1HMaces/WarPick/WarPick.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.4;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[1] = 1.7;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarPickItem;
BasePrefireAnimTime =0.8;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1.4;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(PracticeLongsword)
{
   id = 23;
   Object_typeID = 574;
   
   shapefile = "art/Models/3D-2D/Weapons/2Hswords/Practice_Longsword/Practice_Longsword_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeLongswordItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Claymore)
{
   id = 24;
   Object_typeID = 575;
   
   shapefile = "art/Models/3D-2D/Weapons/2Hswords/Claymore/Claymore.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 5;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 3.1;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.15;
   FractureMultiplier = 1;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ClaymoreItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1.2;
BaseRecoilAnimTime = 1.3;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Zweihaender)
{
   id = 25;
   Object_typeID = 576;
   
   shapefile = "art/Models/3D-2D/Weapons/2Hswords/zweihaender/zweihander.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.2;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 3.3;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.1;
   FractureMultiplier = 1.1;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ZweihaenderItem;
BasePrefireAnimTime =1.3;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Flamberge)
{
   id = 26;
   Object_typeID = 577;
   
   shapefile = "art/Models/3D-2D/Weapons/2Hswords/Flamberge/flamberge.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.5;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 3.2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.5;
   FractureMultiplier = 1;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = FlambergeItem;
BasePrefireAnimTime = 1.2;
BaseFireAnimTime = 1.5;
BaseRecoilAnimTime = 1.7;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(PracticeGreataxe)
{
   id = 27;
   Object_typeID = 578;
   
   shapefile = "art/Models/3D-2D/Weapons/2HAxes/Practice_Greataxe/Practice_Greataxe_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeGreataxeItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Pollaxe)
{
   id = 28;
   Object_typeID = 579;
   
   shapefile = "art/Models/3D-2D/Weapons/2HAxes/pollaxe/pollaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.1;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.9;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.6;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PollaxeItem;
BasePrefireAnimTime =1.6;
BaseFireAnimTime = 1.1;
BaseRecoilAnimTime = 1.1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Bardiche)
{
   id = 29;
   Object_typeID = 580;
   
   shapefile = "art/Models/3D-2D/Weapons/2HAxes/bardiche/Bardiche.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.4;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 1.5;
   StunMultiplier = 0.8;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BardicheItem;
BasePrefireAnimTime =1.5;
BaseFireAnimTime = 1.2;
BaseRecoilAnimTime = 2.1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(BroadAxe)
{
   id = 30;
   Object_typeID = 581;
   
   shapefile = "art/Models/3D-2D/Weapons/2HAxes/BroadAxe/BroadAxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.9;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 1.7;
   StunMultiplier = 0.4;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BroadAxeItem;
BasePrefireAnimTime =1.6;
BaseFireAnimTime = 1.3;
BaseRecoilAnimTime = 2.2;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(SledgeHammer)
{
   id = 31;
   Object_typeID = 582;
   
   shapefile = "art/Models/3D-2D/Weapons/2HMaces/SledgeHammer/SledgeHammer.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2.1;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 2;
   StunMultiplier = 2.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SledgeHammerItem;
BasePrefireAnimTime =1.5;
BaseFireAnimTime = 1.6;
BaseRecoilAnimTime = 2.2;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Maul)
{
   id = 32;
   Object_typeID = 583;
   
   shapefile = "art/Models/3D-2D/Weapons/2HMaces/Maul/Maul.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2.1;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 1.8;
   StunMultiplier = 2.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MaulItem;
BasePrefireAnimTime = 1.6;
BaseFireAnimTime = 1.7;
BaseRecoilAnimTime = 2.2;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(PracticeMaul)
{
   id = 33;
   Object_typeID = 584;
   
   shapefile = "art/Models/3D-2D/Weapons/2HMaces/Practice_Maul/Practice_Maul_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = Weapon2HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.1;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 1;
   StunMultiplier = 2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeMaulItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Glaive)
{
   id = 34;
   Object_typeID = 585;
   
   shapefile = "art/Models/3D-2D/Weapons/Polearms/Glaive/Glaive.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.1;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.1;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.4;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = GlaiveItem;
BasePrefireAnimTime =1.4;
BaseFireAnimTime = 1.2;
BaseRecoilAnimTime = 0.9;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Guisarme)
{
   id = 35;
   Object_typeID = 586;
   
   shapefile = "art/Models/3D-2D/Weapons/Polearms/Guisarme/Guisarme.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.1;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.15;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.1;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = GuisarmeItem;
BasePrefireAnimTime =1.4;
BaseFireAnimTime = 1.1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(WarScythe)
{
   id = 36;
   Object_typeID = 587;
   
   shapefile = "art/Models/3D-2D/Weapons/Polearms/WarScythe/WarScythe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.6;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.1;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 0.2;
   StunMultiplier = 0.15;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarScytheItem;
BasePrefireAnimTime =1.4;
BaseFireAnimTime = 1.3;
BaseRecoilAnimTime = 1.6;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Pitchfork)
{
   id = 37;
   Object_typeID = 588;
   
   shapefile = "art/Models/3D-2D/Weapons/Polearms/Pitchfork/Pitchfork.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PitchforkItem;
BasePrefireAnimTime =1.1;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1.2;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Partisan)
{
   id = 38;
   Object_typeID = 589;
   
   shapefile = "art/Models/3D-2D/Weapons/Polearms/Partisan/Partisan.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.4;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.4;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0.2;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PartisanItem;
BasePrefireAnimTime =1.2;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 0.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Staff)
{
   id = 39;
   Object_typeID = 590;
   
   shapefile = "art/Models/3D-2D/Weapons/Polearms/Staff/Staff.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = StaffItem;
BasePrefireAnimTime =0.7;
BaseFireAnimTime = 0.7;
BaseRecoilAnimTime = 0.7;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Spear)
{
   id = 40;
   Object_typeID = 591;
   
   shapefile = "art/Models/3D-2D/Weapons/Spears/Spear/Spear_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponSpear;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.9;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SpearItem;
BasePrefireAnimTime =0.8;
BaseFireAnimTime = 0.8;
BaseRecoilAnimTime = 0.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(BoarSpear)
{
   id = 41;
   Object_typeID = 592;
   
   shapefile = "art/Models/3D-2D/Weapons/Spears/BoarSpear/Boar_Spear_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponSpear;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0;
   StunMultiplier = 0.25;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BoarSpearItem;
BasePrefireAnimTime =0.8;
BaseFireAnimTime = 0.7;
BaseRecoilAnimTime = 1.1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(AwlPike)
{
   id = 42;
   Object_typeID = 593;
   
   shapefile = "art/Models/3D-2D/Weapons/Spears/Awlpike/Ahlspiess_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponSpear;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.2;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = AwlPikeItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 0.8;
BaseRecoilAnimTime = 0.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(BecdeCorbin)
{
   id = 43;
   Object_typeID = 594;
   
   shapefile = "art/Models/3D-2D/Weapons/Spears/BecdeCorbin/Bec_de_Corbin_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponSpear;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.2;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[1] = 2.2;
   hitGroupType[2] = Blunt;
   hitGroupDmgLevel[2] = 0.8;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BecdeCorbinItem;
BasePrefireAnimTime =1.5;
BaseFireAnimTime = 0.9;
BaseRecoilAnimTime = 1.3;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(ShortPike)
{
   id = 44;
   Object_typeID = 595;
   
   shapefile = "art/Models/3D-2D/Weapons/Pikes/ShortPike/Short_Pike_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponPike;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.5;
   hitGroupType[1] =  Blunt;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ShortPikeItem;
BasePrefireAnimTime =0.7;
BaseFireAnimTime = 3.0;
BaseRecoilAnimTime = 0.9;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(MediumPike)
{
   id = 45;
   Object_typeID = 596;
   
   shapefile = "art/Models/3D-2D/Weapons/Pikes/MediumPike/Medium_Pike_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponPike;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.9;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MediumPikeItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 3.0;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(LongPike)
{
   id = 46;
   Object_typeID = 597;
   
   shapefile = "art/Models/3D-2D/Weapons/Pikes/LongPike/Long_Pike_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponPike;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.9;
   hitGroupType[1] =  Blunt;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = LongPikeItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 3.0;
BaseRecoilAnimTime = 1.2;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Lance)
{
   id = 47;
   Object_typeID = 598;
   
   shapefile = "art/Models/3D-2D/Weapons/Lances/Lance/Lance_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponLance;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0;
   StunMultiplier = 0.5;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = LanceItem;
BasePrefireAnimTime =1.2;
BaseFireAnimTime = 3.0;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire; stateCheckTransition[1] = true; 
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(JoustingLance)
{
   id = 48;
   Object_typeID = 599;
   
   shapefile = "art/Models/3D-2D/Weapons/Lances/JoustingLance/Jousting_Lance_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponLance;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 3.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.5;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = JoustingLanceItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 3.0;
BaseRecoilAnimTime = 0.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire; stateCheckTransition[1] = true; 
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Targeshield)
{
   id = 70;
   Object_typeID = 612;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/RoundShield_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = TargeshieldItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitiveshield)
{
   id = 71;
   Object_typeID = 613;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/PrimitiveShield_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PrimitiveshieldItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Bucklershield)
{
   id = 72;
   Object_typeID = 614;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/Buckler_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BucklershieldItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Heatershield)
{
   id = 73;
   Object_typeID = 615;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/HeaterShield_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeatershieldItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Kiteshield)
{
   id = 74;
   Object_typeID = 616;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/KiteShield_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KiteshieldItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Towershield)
{
   id = 75;
   Object_typeID = 617;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/TowerShield_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = TowershieldItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Pavise)
{
   id = 76;
   Object_typeID = 618;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/PaviseShield_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PaviseItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Shovel)
{
   id = 120;
   Object_typeID = 40;
   
   shapefile = "art/Models/3D-2D/Tools/Shovel_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ShovelItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_shovel)
{
   id = 121;
   Object_typeID = 41;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveShovel_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_shovelItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_pickaxe)
{
   id = 122;
   Object_typeID = 47;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitivePickaxe_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_pickaxeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Pickaxe)
{
   id = 123;
   Object_typeID = 48;
   
   shapefile = "art/Models/3D-2D/Tools/Pickaxe_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PickaxeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Hardened_steel_pickaxe)
{
   id = 124;
   Object_typeID = 49;
   
   shapefile = "art/Models/3D-2D/Tools/SteelPickaxe_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] = Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Hardened_steel_pickaxeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_hammer)
{
   id = 125;
   Object_typeID = 43;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveBlacksmithHammer_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_hammerItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Smiths_Hammer)
{
   id = 126;
   Object_typeID = 42;
   
   shapefile = "art/Models/3D-2D/Tools/BlacksmithHammer_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Smiths_HammerItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Mallet)
{
   id = 127;
   Object_typeID = 44;
   
   shapefile = "art/Models/3D-2D/Tools/Mallet_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MalletItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Fishing_Pole)
{
   id = 128;
   Object_typeID = 621;
   
   shapefile = "art/Models/3D-2D/Tools/FishingRod_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Fishing_PoleItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_Axe)
{
   id = 129;
   Object_typeID = 45;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveAxe_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_AxeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Hatchet)
{
   id = 130;
   Object_typeID = 46;
   
   shapefile = "art/Models/3D-2D/Tools/Hatchet_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HatchetItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_Saw)
{
   id = 131;
   Object_typeID = 50;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveSaw_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_SawItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Saw)
{
   id = 132;
   Object_typeID = 51;
   
   shapefile = "art/Models/3D-2D/Tools/Saw_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SawItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_CrucibleandStick)
{
   id = 133;
   Object_typeID = 463;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveCaS_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_CrucibleandStickItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(CrucibleandTongs)
{
   id = 134;
   Object_typeID = 464;
   
   shapefile = "art/Models/3D-2D/Tools/CaS_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = CrucibleandTongsItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_Sickle)
{
   id = 135;
   Object_typeID = 30;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveSickle_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_SickleItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Sickle)
{
   id = 136;
   Object_typeID = 33;
   
   shapefile = "art/Models/3D-2D/Tools/Sickle_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.7;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.1;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SickleItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(HeavyTarge)
{
   id = 147;
   Object_typeID = 1066;
   
   shapefile = "art/Models/3D-2D/Armors/Shields/SteelRoundache_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeavyTargeItem;
// Armed. Idle
   stateName[0] = "Ready";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "BlockingReady";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   
   // State for attached(inactive) weapons. Manually-controlled state
      stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};

datablock ShapeBaseImageData(Primitive_Cooking_Pot)
{
   id = 319;
   Object_typeID = 1028;
   
   shapefile = "art/Models/3D-2D/Tools/PrimitiveCookingPot_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_Cooking_PotItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Cooking_Pot)
{
   id = 320;
   Object_typeID = 1029;
   
   shapefile = "art/Models/3D-2D/Tools/CookingPot_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Cooking_PotItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Primitive_Knife)
{
   id = 321;
   Object_typeID = 289;
   
   shapefile = "art/Models/3D-2D/Tools/PrimKnife_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_KnifeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Knife)
{
   id = 322;
   Object_typeID = 290;
   
   shapefile = "art/Models/3D-2D/Tools/SimpleKnife_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1;
   hitGroupType[1] = Slashing;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KnifeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Skinning_knife)
{
   id = 323;
   Object_typeID = 291;
   
   shapefile = "art/Models/3D-2D/Tools/HeavyKnife_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] = Slashing;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Skinning_knifeItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Glassblower_toolkit)
{
   id = 324;
   Object_typeID = 294;
   
   shapefile = "art/Models/3D-2D/Tools/GStick_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Glassblower_toolkitItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Bear_Paw)
{
   id = 325;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 2;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Bear_PawItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Wild_Horse_Hoof)
{
   id = 326;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.5;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Wild_Horse_HoofItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Deer_Hoof)
{
   id = 327;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.6;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Deer_HoofItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Hind_Hoof)
{
   id = 328;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.5;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Hind_HoofItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Wolf_Fang)
{
   id = 329;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.3;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 0.2;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Wolf_FangItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Moose_Hoof)
{
   id = 330;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.8;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Moose_HoofItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Boar_Tusk)
{
   id = 331;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.3;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.4;
   FractureMultiplier = 0.2;
   StunMultiplier = 0.4;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Boar_TuskItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Sow_Tusk)
{
   id = 332;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.2;
   FractureMultiplier = 0.1;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Sow_TuskItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Mutton_Horns)
{
   id = 333;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.4;
   StunMultiplier = 0.5;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Mutton_HornsItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Bull_Horns)
{
   id = 334;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.6;
   StunMultiplier = 0.8;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Bull_HornsItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Cow_Horns)
{
   id = 335;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.7;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Cow_HornsItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Primitive_Fishing_Pole)
{
   id = 336;
   Object_typeID = 620;
   
   shapefile = "art/Models/3D-2D/Tools/FishingRod_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_Fishing_PoleItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(Torch)
{
   id = 337;
   Object_typeID = 38;
   
   shapefile = "art/Models/3D-2D/Tools/Torch_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon_spear;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 1.6;
   hitGroupType[1] = Siege;
   hitGroupDmgLevel[1] = 1.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = TorchItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 1;
BaseRecoilAnimTime = 1;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   //permanentEmitter[0] = FireOfTorchEmitter;
   permanentEmitter[0] = weapon_smoke;
   permanentEmitter[1] = SparksOfTorchEmitter;
   //permanentEmitterNode[0] = "fire_node";
   permanentEmitterNode[0] = "smoke_node";
   permanentEmitterNode[1] = "sparks_node";
   
   fireEmitter = TestFireEmitter;
   fireEmitterNode = "fire_node";
   
   animatedBillboard = TestAnimatedBillboard;
   animatedBillboardNode = "fire_node";
   
   permanentSound = TorchFireSound;
   
   lightType=ConstantLight;
   lightColor = "1.0 1.0 0.9";
   lightRadius = 20;
   lightImageNode = "fire_node";

   lightPrototype = "Torch_light";
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};

datablock ShapeBaseImageData(DecoratedJoustingLance)
{
   id = 338;
   Object_typeID = 1141;
   
   shapefile = "art/Models/3D-2D/Weapons/Lances/DecoratedJoustingLance/Jousting_Lance_EXPORT_02.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponLance;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Piercing;
   hitGroupDmgLevel[0] = 2.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.5;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = DecoratedJoustingLanceItem;
BasePrefireAnimTime =1;
BaseFireAnimTime = 3.0;
BaseRecoilAnimTime = 0.8;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire; stateCheckTransition[1] = true; 
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};

datablock ShapeBaseImageData(HandOfBoris)
{
   id = 583;
   Object_typeID = 1120;
   
   shapefile = "art/Models/3D-2D/Weapons/Unarmed/fist.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackUnarmed;
   WeaponType = WeaponUnarmed;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HandOfBorisItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(HandOfIlyas)
{
   id = 584;
   Object_typeID = 1122;
   
   shapefile = "art/Models/3D-2D/Weapons/Unarmed/fist.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackUnarmed;
   WeaponType = WeaponUnarmed;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HandOfIlyasItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};
datablock ShapeBaseImageData(Dire_Wolf_Fang)
{
   id = 1329;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0.4;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Wolf_FangItem;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
};
datablock ShapeBaseImageData(KnightSword)
{
   id = 1330;
   Object_typeID = 3338;
   
   shapefile = "art/Models/3D-2D/Terra/Weapons/Mithril_1HSwords/KnightSword/Mithril_Knight_Sword_EXPORT_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 5.0;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KnightSwordItem;
BasePrefireAnimTime = 1.2;
BaseFireAnimTime = 1.2;
BaseRecoilAnimTime = 1.4;
 // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;
   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;
   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;
   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;
   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;
   
   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
};