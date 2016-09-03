//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AI_AnimalData(WolfData : DefaultPlayerData)   // datablock PlayerData
{
   id = 143; //CM_REV
  
   animal_breed_object_id = 755;
   footprintTexture = "art/Textures/AnimalFootprints/Wolf_fs.png";
   footprintTextureLinearSize = 0.4;
   footprintGap = 0.6;
   footprintTrackWidth = 0.4;
   shapeFile = "art/Models/3D/Mobiles/WildAnimals/Wolf/Wolf.dts";
   sound_files_prefix = "wolf";


   boundingBox = "1 2.4 1.8"; //"1.2 6.2 3.5";    7
   is_two_capsules_physical_body = 1;
};
