
singleton Material(newMaterial3)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/terrains/Textures/SkyColor1.jpg";
   specularPower[0] = "74";
   parallaxScale[0] = "0";
   glow[0] = "0";
   castShadows = "0";
   showFootprints = "0";
};

singleton Material(newMaterial5)
{
   mapTo = "unmapped_mat";
   cubemap = "NewLevelSkyCubemap";
};

// Customization
exec("art/customization_data.cs");

//Tunnel walls, floor and ceiling-----------------------------------------------------------------------------------------------

// soil
singleton Material(TunnelWallsMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   streamable = "0";
};

//SteppeSoil
singleton Material(TunnelWallsSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

singleton Material(TunnelFloorSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

singleton Material(TunnelCeilingSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

//Rock
singleton Material(TunnelWallsRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
 //diffuseMap[2] = "art/Textures/TunnelTextures/Rock/Rock_spec.dds";
   streamable = "0";
};

singleton Material(TunnelFloorRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//RockBare
singleton Material(TunnelWallsRockBareMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_diff.DDS";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Granite
singleton Material(TunnelWallsGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_ceiling.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//GraniteFrag
singleton Material(TunnelWallsGraniteFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Granite_fragments/Granite_Frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Marble
singleton Material(TunnelWallsMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//MarbleFrag
singleton Material(TunnelWallsMarbleFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Marble_fragments/Marble_frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Slate
singleton Material(TunnelWallsSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//SlateFrag
singleton Material(TunnelWallsSlateFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Slate_fragments/Slate_frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//GoldOre
singleton Material(TunnelWallsGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelFloorGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Ceiling_Dif.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//GoldOreFrag
singleton Material(TunnelWallsGoldOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Gold_ore/Gold_Ore_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//IronOre
singleton Material(TunnelFloorIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//IronOreFrag
singleton Material(TunnelWallsIronOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Iron_ore/Iron_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//SilverOre
singleton Material(TunnelFloorSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//SilverOreFrag
singleton Material(TunnelWallsSilverOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Silver_ore/Silver_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//CopperOre
singleton Material(TunnelFloorCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//CopperOreFrag
singleton Material(TunnelWallsCopperOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Copper_ore/Copper_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//Sand
singleton Material(TunnelWallsSandMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Sand/Sand_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Clay
singleton Material(TunnelWallsClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/Clay_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   streamable = "0";
};

//Snow
singleton Material(TunnelWallsSnowMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Snow/Snow_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Snow/Snow_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Swamp
singleton Material(TunnelWallsSwampMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_spec.dds";
   streamable = "0";
};

//RiverRock
singleton Material(TunnelWallsRiverRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/River_rock/River_Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/River_rock/River_Rock_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

// Environment (trees, bushes et.c.)-----------------------------------------------------------------------------------------------

singleton Material(SpruceBark1_mat)
{
   mapTo = "SpruceBark1";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Spruce_001/Spruce_Bark_001_Dif.dds";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Spruce_001/Spruce_Bark_001_Nrm.dds";
   materialTag0 = "LiF";
};

singleton Material(SpruceFolieage1_mat)
{
   mapTo = "SpruceFolieage1";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Spruce_001/Spruce_Foli_001_Dif.dds";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Spruce_001/Spruce_Foli_001_Nrm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "33";
   materialTag0 = "LiF";
};

singleton Material(ImposterMat_mat)
{
   mapTo = "ImposterMat";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Spruce_001/Spruce_Imposter.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "161";
   materialTag0 = "LiF";
};

// Weapons and armor

singleton Material(war_axe_mat)
{
   mapTo = "War_Axe_03.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Flanged_Mace_mat)
{
   mapTo = "Flanged_Mace_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Morgenstern_02_jpg_mat)
{
   mapTo = "Morgenstern_02.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Bardiche_01_jpg_mat)
{
   mapTo = "Bardiche_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Claymore_01_mat)
{
   mapTo = "Claymore_DIFFUSE_01.dds";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Cudgel_01_jpg_mat)
{
   mapTo = "Cudgel_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_02_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_02_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_02_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Maul_DIFFUSE_01_jpg_mat)
{
   mapTo = "Maul_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_02_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_02_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_02_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Nordic_Axe_01_jpg_mat)
{
   mapTo = "Nordic_Axe_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_02_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_02_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_02_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Weapon_Pack_03_DIFFUSE_01_mat)
{
   mapTo = "Weapon_Pack_03_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_03_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_03_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_03_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

// Atlas Materials

singleton Material(shops_01_atlas_diff_mat)
{
   mapTo = "shops-01-atlas-diff";
   diffuseMap[0] = "art/Textures/Atlas/shops-01-atlas-diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops-01-atlas-nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops-01-atlas-spec.dds";
   diffuseMap[12] = "art/Textures/Atlas/shops-01-atlas-emiss.dds";
   emission="1";
   emissionIntensityFreq="0.8";
   emissionIntensityMin="0.07";
   emissionIntensityMax="0.45";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "154";
};

// Texture library materials

singleton Material(brick_01_diff_mat)
{
   mapTo = "brick-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/small_brick_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/small_brick_01_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(wood_floor_01_diff_mat)
{
   mapTo = "wood_floor-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_floor_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_floor_01_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(wood_diffuce_01_mat2)
{
   mapTo = "wood_diffuce_01";
   diffuseMap[0] = "art/Textures/TextureLib/wood_diffuce_01.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_normal_01.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wood_specular_01.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};
singleton Material(planks01)
{
   mapTo = "planks-01-diff";
   diffuseMap[0] = "art/textures/textureLib/planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(planks_01_diff)
{
   mapTo = "planks_01_diff";
   diffuseMap[0] = "art/textures/textureLib/planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(planks02)
{
   mapTo = "planks-02-diff";
   diffuseMap[0] = "art/textures/textureLib/planks_02_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(planks_02_diff)
{
   mapTo = "planks_02_diff";
   diffuseMap[0] = "art/textures/textureLib/planks_02_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(small_brick01)
{
   mapTo = "small_brick-01-diff";
   diffuseMap[0] = "art/textures/textureLib/small_brick_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/small_brick_01_nm.dds";
   specularPower[0] = "19";
   diffuseMap[2] = "art/textures/textureLib/small_brick_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(felling02)
{
   mapTo = "felling-02-diff";
   diffuseMap[0] = "art/textures/textureLib/felling_02_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/felling_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(whitewash_mat)
{
   mapTo = "whitewash";
   diffuseMap[0] = "art/Textures/TextureLib/whitewash.dds";
   diffuseMap[1] = "art/Textures/TextureLib/whitewash_n.dds";
   materialTag0 = "LiF";
};

singleton Material(door01)
{
   mapTo = "door-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/door_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/door_01_nm.dds";
   specularPower[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/door_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(door_01_diff)
{
   mapTo = "door_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/door_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/door_01_nm.dds";
   specularPower[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/door_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(brick_big01)
{
   mapTo = "brick_big_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/brick_big_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/brick_big_01_nm.dds";
   specularPower[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/brick_big_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(stone_floor01)
{
   mapTo = "stone-floor-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_floor_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_floor_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(roof_planks01)
{
   mapTo = "roof_planks-01-diff";
   diffuseMap[0] = "art/textures/textureLib/roof_planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/roof_planks_01_nm.dds";
   useAnisotropic[0] = "1";
   translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "134";
   specularPower[0] = "1";
   doubleSided = "1";
   materialTag0 = "LiF";
};

singleton Material(roof_planks_01_diff)
{
   mapTo = "roof_planks_01_diff";
   diffuseMap[0] = "art/textures/textureLib/roof_planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/roof_planks_01_nm.dds";
   useAnisotropic[0] = "1";
   translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "134";
   specularPower[0] = "1";
   doubleSided = "1";
   materialTag0 = "LiF";
};

singleton Material(felling01)
{
   mapTo = "felling-01-diff";
   diffuseMap[0] = "art/textures/textureLib/felling_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/felling_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(felling_01_diff)
{
   mapTo = "felling_01_diff";
   diffuseMap[0] = "art/textures/textureLib/felling_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/felling_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(ovencoal_mat)
{
   mapTo = "ovencoal";
   diffuseMap[0] = "art/Textures/TextureLib/ovencoal.dds";
   materialTag0 = "LiF";
};

singleton Material(SmoothWood_mat)
{
   mapTo = "SmoothWood";
   diffuseMap[0] = "art/Textures/TextureLib/SmoothWood.dds";
   diffuseMap[1] = "art/Textures/TextureLib/SmoothWood_n.dds";
   materialTag0 = "LiF";
};

singleton Material(Distaff_mat)
{
   mapTo = "Distaff";
   diffuseMap[0] = "art/Textures/TextureLib/Distaff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Distaff_n.dds";
   materialTag0 = "LiF";
};

singleton Material(Wicker_01_mat)
{
   mapTo = "Wicker_01";
   diffuseMap[0] = "art/Textures/TextureLib/Wicker_01.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Wicker_01_n.dds";
   materialTag0 = "LiF";
};

singleton Material(cloth_color_mat)
{
   mapTo = "cloth_color";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_color.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_normals.dds";
};

singleton Material(cloth_nobump_mat)
{
   mapTo = "cloth_nobump";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_color.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_normals.dds";
   materialTag0 = "LiF";
};

// Unique textures

singleton Material(sack_mat)
{
   mapTo = "sack";
   diffuseMap[0] = "art/Textures/TextureLib/sack.dds";
   diffuseMap[1] = "art/Textures/TextureLib/sack_n.dds";
   materialTag0 = "LiF";
};

singleton Material(ExpensiveDesk_mat)
{
   mapTo = "ExpensiveDesk";
   diffuseMap[0] = "art/Textures/TextureLib/ExpensiveDesk.dds";
   diffuseMap[1] = "art/Textures/TextureLib/ExpensiveDesk_n.dds";
   materialTag0 = "LiF";
};


singleton Material(Utensil_d_mat)
{
   mapTo = "Utensil_d";
   diffuseMap[0] = "art/Textures/TextureLib/Utensil_d.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Utensil_n.dds";
   vertColor[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(barrel_mat)
{
   mapTo = "barrel";
   diffuseMap[0] = "art/Textures/TextureLib/barrel.dds";
   diffuseMap[1] = "art/Textures/TextureLib/barrel_n.dds";
   diffuseMap[2] = "art/Textures/TextureLib/barrel_S.dds";
   materialTag0 = "LiF";
};

singleton Material(utensil_02_mat)
{
   mapTo = "Utensil_02";
   diffuseMap[0] = "art/Textures/TextureLib/Utensil_02.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Utensil_02_n.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
};

singleton Material(Utensil_1_mat)
{
   mapTo = "Pasuda_d";
   diffuseMap[0] = "art/Textures/TextureLib/Utensil_d.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Utensil_n.dds";
   vertColor[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(decbed_diffuce_mat)
{
   mapTo = "decbed_diffuce";
   diffuseMap[0] = "art/Textures/TextureLib/decbed_diffuce.dds";
   diffuseMap[1] = "art/Textures/TextureLib/decbed_normals.dds";
   materialTag0 = "LiF";
};


singleton Material(Weapon_Pack_04_03_jpg_mat)
{
   mapTo = "Weapon_Pack_04_03.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Weapon_Pack_05B_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_05B_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(fakhverk_atlas_01_diff_mat)
{
   mapTo = "fakhverk_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/fakhverk_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fakhverk_atlas_01_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(thatched_01_diff_mat)
{
   mapTo = "thatched_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/thatched_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/thatched_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(thatched_02_diff_mat)
{
   mapTo = "thatched_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/thatched_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/thatched_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(wood_roof_01_diff_mat)
{
   mapTo = "wood_roof_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_roof_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_roof_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
   specularPower[0] = "38";
   pixelSpecular[0] = "1";
};

singleton Material(wood_moss_01_diff_mat)
{
   mapTo = "wood_moss_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_moss_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_moss_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wood_moss_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   specularPower[0] = "56";
   pixelSpecular[0] = "1";
};

singleton Material(bark_02_diff_mat)
{
   mapTo = "bark_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/bark_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/bark_02_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(Weapon_Pack_06_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_06_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_06_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_06_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_06_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};


singleton Material(Weapon_Pack_07_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_07_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_07_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_07_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_07_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(sprucet_mat)
{
   mapTo = "sprucet";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/spruce/images/diff.dds";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/spruce/images/diff_n.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
   materialTag0 = "LiF";
};

singleton Material(Horse_DIFFUSE_WHITE_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BLACK_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_BLACK_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BW_01_png_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BW_01.png";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BLACK_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_BLACK_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BW_01_png_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BW_01.png";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(pine_test_11_mat)
{
   mapTo = "pine_test_11";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Pine/images/tex_pine.dds";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Pine/images/tex_pine_N.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
};

singleton Material(fence_wood_diff_mat)
{
   mapTo = "fence_wood_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fence_wood_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fence_wood_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
};

singleton Material(brick_big_02_diff_mat)
{
   mapTo = "brick_big_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/brick_2.dds";
   diffuseMap[1] = "art/Textures/TextureLib/brick_2_normal.dds";
   diffuseMap[2] = "art/Textures/TextureLib/brick_2_spec.dds";
   materialTag0 = "LiF";
   materialTag0 = "LiF";
};

singleton Material(rivet_diff_mat)
{
   mapTo = "rivet_diff";
   diffuseMap[0] = "art/Textures/TextureLib/rivet_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/rivet_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(shops_02_atlas_diff_mat)
{
   mapTo = "shops_02_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/shops_02_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_02_atlas_nm.dds";
   materialTag0 = "LiF";
   specularPower[0] = "2";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Weapon_Pack_06_DIFFUSE_01_mat)
{
   mapTo = "Weapon_Pack_06_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_06_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_06_NORMALMAP_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};


singleton Material(Deer_Diffuse_mat)
{
   mapTo = "Deer_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_Normal.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(birch21_birch_mat)
{
   mapTo = "birch_mat";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/birch/images/test_all_d.dds";
   specularPower[0] = "2";
   doubleSided = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/birch/images/test_all_n.dds";
   diffuseMap[2] = "art/Models/3D/Environment/Trees/birch/images/test_all_s.dds";
   materialTag0 = "LiF";
};

singleton Material(Heavy_Horse1_DIFFUSE_05_jpg_mat)
{
   mapTo = "Heavy_Horse1_DIFFUSE_05.jpg";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse1_DIFFUSE_05_jpg_mat)
{
   mapTo = "Heavy_Horse1_DIFFUSE_05.jpg";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_leather_trousers_diff_mat)
{
   mapTo = "female_leather_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/female_leather_trousers_diff.tga";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/female_leather_trousers_nm.tga";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/female_leather_trousers_spec.tga";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_leather_cape_diff_mat)
{
   mapTo = "female_leather_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/female_leather_cape_diff.tga";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/female_leather_cape_nm.tga";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/female_leather_cape_spec.tga";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(willow_mat_mat)
{
   mapTo = "willow_mat";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Willow/images/test_01.dds";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Willow/images/test_01_n.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
   materialTag0 = "LiF";
};

singleton Material(stone_big_diff_mat)
{
   mapTo = "stone_big_diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_big_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_big_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/stone_big_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(floor_diff_mat)
{
   mapTo = "floor_diff";
   diffuseMap[0] = "art/Textures/TextureLib/floor_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/floor_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(stone_big_moss_diff_mat)
{
   mapTo = "stone_big_moss_diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_big_moss_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_big_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/stone_big_moss_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Sheep_Diffuse2_mat)
{
   mapTo = "Sheep_Diffuse2";
   diffuseMap[0] = "art/Textures/Animals/Sheep/Sheep_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Sheep/Sheep_Normal.dds";
   materialTag0 = "LiF";
};

singleton Material(Milaneese_Armor_DIFFUSE_01_jpg_mat)
{
   mapTo = "Milaneese_Armor_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
   isHeraldic = "1";
   heraldicCustomizationData = HeaterShieldHeraldry;
};

singleton Material(WildHorse_D_mat)
{
   mapTo = "WildHorse_D";
   diffuseMap[0] = "art/Textures/Animals/wildhorse/WildHorse_D.dds";
   diffuseMap[1] = "art/Textures/Animals/wildhorse/WildHorse_N.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
};

singleton Material(Pig_Diffuse_2_mat)
{
   mapTo = "Pig_Diffuse_2";
   diffuseMap[0] = "art/Textures/Animals/domesticPig/Pig_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/domesticPig/Pig_Normals.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(elm_tex_mat)
{
   mapTo = "elm_tex";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Elm/tex/elm_tex.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Elm/tex/elm_tex_n.dds";
   materialTag0 = "LiF";
};

singleton Material(plaster_diff_mat)
{
   mapTo = "plaster_diff";
   diffuseMap[0] = "art/Textures/TextureLib/plaster_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/plaster_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(tent_cloth_mat)
{
   mapTo = "tent_cloth_diff";
   diffuseMap[0] = "art/Textures/TextureLib/tent_cloth_diff.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   materialTag0 = "LiF";
};

singleton Material(tent_cloth_diff_decor_mat)
{
   mapTo = "tent_cloth_diff_decor";
   diffuseMap[0] = "art/Textures/Atlas/tent_cloth_diff_decor.dds";
};

singleton Material(ruins_diff_mat)
{
   mapTo = "ruins_diff";
   diffuseMap[0] = "art/Textures/TextureLib/ruins_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/ruins_nm.dds";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/ruins_diff.dds";
   diffuseMap[12] = "art/Textures/TextureLib/ruins_emiss.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   emission="1";
   emissionIntensityFreq="0.8";
   emissionIntensityMin="0.1";
   emissionIntensityMax="0.6";
};

singleton Material(blacksmith_atlas_diff_mat)
{
   mapTo = "blacksmith-atlas-diff";
   diffuseMap[0] = "art/Textures/Atlas/shops-01-atlas-diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops-01-atlas-nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops-01-atlas-spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Oak31_OakMat)
{
   mapTo = "OakMat";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Oak/texture/Oak01.dds";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "30";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "33";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Oak/texture/Oak01_normal.dds";
   diffuseMap[2] = "art/Models/3D/Environment/Trees/Oak/texture/Oak01_specular.dds";
   materialTag0 = "LiF";
};

singleton Material(apple_tex_mat)
{
   mapTo = "apple_tex";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Apple/Texture/apple_tex_d.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Apple/Texture/apple_tex_n.dds";
   materialTag0 = "LiF";
};

singleton Material(CommonHorseFootprint)
{
   diffuseMap[0] = "art/2D/Terrain/Footsteps/horse_footprint.dds";
   vertColor[0] = true;
   translucent = true;
   castShadows = "0";
   translucentZWrite = "1";
};

singleton Material(Maple31_MapleLeaf)
{
   mapTo = "MapleLeaf";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Maple/texture/MaspleLeaf.dds";
   specular[0] = "0.0470588 0.0470588 0.0470588 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Maple/texture/MaspleLeaf_normal.dds";
   pixelSpecular[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.941177 0.933333 0.8 1";
   subSurfaceRolloff[0] = "0.1";
   materialTag0 = "LiF";
   diffuseMap[2] = "art/Models/3D/Environment/Trees/Maple/texture/MaspleLeaf_spec.dds";
};

singleton Material(Maple31_MapleBark)
{
   mapTo = "MapleBark";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/Maple/texture/MapleBark.dds";
   specular[0] = "0.152941 0.152941 0.152941 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/Maple/texture/MapleBark_normal.dds";
   pixelSpecular[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(detail_wine_mat)
{
   mapTo = "detail_wine";
   diffuseMap[0] = "art/Textures/TextureLib/detail_wine.dds";
   diffuseMap[1] = "art/Textures/TextureLib/detail_wine_nrm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/detail_wine_SPEC.dds";
   materialTag0 = "LiF";
   specularPower[0] = "54";
   pixelSpecular[0] = "1";
   alphaTest = "1";
   alphaRef = "54";
};

singleton Material(roof_tile_diff_mat)
{
   mapTo = "roof_tile_diff";
   diffuseMap[0] = "art/Textures/TextureLib/roof_tile_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/roof_tile_nm.dds";
   materialTag0 = "LiF";
   pixelSpecular[0] = "1";
   specularPower[0] = "38";
   doubleSided = "1";
};

singleton Material(leather_helmet_diff_mat)
{
   mapTo = "leather_helmet_diff";
   diffuseMap[0] = "art/Models/3D-2D/Armors/Leather/male_lamelar_leather/leather_helmet_diff.tga";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/leather_helmet_nm.tga";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/leather_helmet_spec.tga";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Milaneese_Armor_DIFFUSE_01_mat)
{
   mapTo = "Milaneese_Armor_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_SPECULAR_01.dds";
   materialTag0 = "LiF";
   // envmap = true;
   //fChrome = 1;
   skinned = true;
   isHeraldic = 1;
};

singleton Material(Milaneese_Armor_DIFFUSE_01_nonskined_mat)
{
   mapTo = "Milaneese_Armor_DIFFUSE_01_nonskined";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/fullplate/Milaneese_Armor_SPECULAR_01.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   //envmap = true;
   //fChrome = 1;
};

singleton Material(murl_test1234_mat)
{
   mapTo = "murl_test1234";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/mulberry/texture/Mulberries_tex3.dds";
   diffuseMap[1] = "art/Models/3D/Environment/Trees/mulberry/texture/Mulberries_tex3_n.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
};


singleton Material(bull_diffuse4_mat)
{
   mapTo = "bull_diffuse4";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_normals.dds";
   materialTag0 = "LiF";
};

singleton Material(Cow_diffuse4_mat)
{
   mapTo = "Cow_diffuse4";
   diffuseMap[0] = "art/Textures/Animals/Cow/Cow_diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Cow/Cow_Normals.dds";
   materialTag0 = "LiF";
};

singleton Material(WildBull_diffuse_mat)
{
   mapTo = "WildBull_diffuse";
   diffuseMap[0] = "art/Textures/Animals/AurochsBull/WildBull_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/AurochsBull/WildBull_Normals.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "46";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(WildCow_Diffuse_mat)
{
   mapTo = "WildCow_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/AurochsCow/WildCow_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/AurochsCow/WildCow_Normals.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "46";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_novice_padded_detail_diff_mat)
{
   mapTo = "male_novice_padded_detail_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/male_novice_padded_detail_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/male_novice_padded_detail_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/male_novice_padded_detail_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_novice_padded_cape_diff_mat)
{
   mapTo = "female_novice_padded_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/female_novice_padded_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/female_novice_padded_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/female_novice_padded_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_novice_padded_cape_diff_mat)
{
   mapTo = "male_novice_padded_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/male_novice_padded_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/male_novice_padded_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/novicepadded/male_novice_padded_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(padded_regular_gloves_diff_mat)
{
   mapTo = "padded_regular_gloves_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/padded_regular_gloves_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/padded_regular_gloves_nm.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(padded_regular_helmet_diff_mat)
{
   mapTo = "padded_regular_helmet_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/padded_regular_helmet_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/padded_regular_helmet_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/padded_regular_helmet_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_regular_padded_trousers_diff_mat)
{
   mapTo = "female_regular_padded_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/female_regular_padded_trousers_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/female_regular_padded_trousers_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/female_regular_padded_trousers_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_regular_padded_cape_diff_mat)
{
   mapTo = "female_regular_padded_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/female_regular_padded_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/female_regular_padded_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/female_regular_padded_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_regular_padded_cape_diff_mat)
{
   mapTo = "male_regular_padded_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/male_regular_padded_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/male_regular_padded_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/male_regular_padded_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_regular_padded_trousers_diff_mat)
{
   mapTo = "male_regular_padded_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/male_regular_padded_trousers_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/male_regular_padded_trousers_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/regularpadded/male_regular_padded_trousers_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(lamellarleather_foot_diff_mat)
{
   mapTo = "lamellarleather_foot_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_foot_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_foot_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_foot_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_lamellarleather_trousers_diff_mat)
{
   mapTo = "female_lamellarleather_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/female_lamellarleather_trousers_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/female_lamellarleather_trousers_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/female_lamellarleather_trousers_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_lamellarleather_cape_diff_mat)
{
   mapTo = "female_lamellarleather_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/female_lamellarleather_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/female_lamellarleather_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/female_lamellarleather_cape_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(lamellarleather_helmet_diff_mat)
{
   mapTo = "lamellarleather_helmet_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_helmet_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_helmet_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_helmet_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(lamellarleather_gloves_diff_mat)
{
   mapTo = "lamellarleather_gloves_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_gloves_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_gloves_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/lamellarleather_gloves_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_lamellarleather_trousers_diff_mat)
{
   mapTo = "male_lamellarleather_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/male_lamellarleather_trousers_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/male_lamellarleather_trousers_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/male_lamellarleather_trousers_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_lamellarleather_cape_diff_mat)
{
   mapTo = "male_lamellarleather_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/male_lamellarleather_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/male_lamellarleather_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/lamellarleather/male_lamellarleather_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(regularscale_helmet_diff_mat)
{
   mapTo = "regularscale_helmet_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_helmet_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_helmet_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_helmet_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(male_regularscale_cape_diff_mat)
{
   mapTo = "male_regularscale_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/male_regularscale_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/male_regularscale_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/male_regularscale_cape_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(regularscale_gloves_diff_mat)
{
   mapTo = "regularscale_gloves_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_gloves_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_gloves_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_gloves_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(regularscale_boot_diff_mat)
{
   mapTo = "regularscale_boot_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_boot_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_boot_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/regularscale_boot_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(male_regularscale_trousers_diff_mat)
{
   mapTo = "male_regularscale_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/male_regularscale_trousers_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/male_regularscale_trousers_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/male_regularscale_trousers_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(female_regularscale_cape_diff_mat)
{
   mapTo = "female_regularscale_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/female_regularscale_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/female_regularscale_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/female_regularscale_cape_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(female_regularscale_trousers_diff_mat)
{
   mapTo = "female_regularscale_trousers_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/female_regularscale_trousers_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/female_regularscale_trousers_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/regularscale/female_regularscale_trousers_spec.dds";
   materialTag0 = "LiF";
   //envmap = true;
  // fChrome = 1;
   skinned = true;
};

singleton Material(cloth_02_diff_mat)
{
   mapTo = "cloth_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_normals.dds";
   materialTag0 = "LiF";
};

singleton Material(Rock01Mat_mat)
{
   mapTo = "Rock01Mat";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   materialTag0 = "LiF";
};

singleton Material(Rock02Mat_mat)
{
   mapTo = "Rock02Mat";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   materialTag0 = "LiF";
};

singleton Material(GrassRockMat_mat)
{
   mapTo = "GrassRockMat";
   diffuseMap[0] = "art/Textures/GroundCover/Grassrock.dds";
   diffuseMap[1] = "art/Textures/GroundCover/GrassrockNm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "10";
};

singleton Material(Rock02_mat)
{
   mapTo = "Rock02";
   diffuseMap[0] = "art/Models/3D/Environment/grass/mountains/Rock_Det.dds";
   materialTag0 = "LiF";
};

singleton Material(heavyleather_armor_diff_mat)
{
   mapTo = "heavyleather_armor_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/heavyleather/heavyleather_armor_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/heavyleather/heavyleather_armor_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/heavyleather/heavyleather_armor_spec.dds";
   specularPower[0] = "10";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};


singleton Material(male_noviceleather_detail_diff_mat)
{
   mapTo = "male_noviceleather_detail_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/male_noviceleather_detail_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/male_noviceleather_detail_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/male_noviceleather_detail_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_noviceleather_cape_diff_mat)
{
   mapTo = "male_noviceleather_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/male_noviceleather_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/male_noviceleather_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/male_noviceleather_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(female_noviceleather_cape_diff_mat)
{
   mapTo = "female_noviceleather_cape_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/female_noviceleather_cape_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/female_noviceleather_cape_nm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/noviceleather/female_noviceleather_cape_spec.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(ForestMat_mat)
{
   mapTo = "ForestMat";
   diffuseMap[0] = "art/Textures/GroundCover/Forest.dds";
   diffuseMap[1] = "art/Textures/GroundCover/ForestNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/ForestSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "LiF";
   castShadows = "0";
};

singleton Material(LogMat_mat)
{
   mapTo = "LogMat";
   diffuseMap[0] = "art/Textures/GroundCover/Log01.dds";
   diffuseMap[1] = "art/Textures/GroundCover/Log01Nm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/Log01Spec.dds";
   materialTag0 = "LiF";
};

singleton Material(SwampMat_mat)
{
   mapTo = "SwampMat";
   diffuseMap[0] = "art/Textures/GroundCover/Swam.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SwamNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/SwamSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "LiF";
   castShadows = "0";
   streamable = "0";
};

singleton Material(SteppeMat_mat)
{
   mapTo = "SteppeMat";
   diffuseMap[0] = "art/Textures/GroundCover/Steppe.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SteppeNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/SteppeSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "LiF";
   castShadows = "0";
   streamable = "0";
};

singleton Material(Boar_Diffuse_mat)
{
   mapTo = "Boar_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/boar/BoarDiffuseFinal.dds";
   diffuseMap[1] = "art/Textures/Animals/boar/BoarNormalsFinal.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Bear_Diffuse_mat)
{
   mapTo = "Bear_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/bear/Bear_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/bear/Bear_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bear/Bear_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Sow_DiffuseFinal_mat)
{
   mapTo = "Sow_DiffuseFinal";
   diffuseMap[0] = "art/Textures/Animals/sow/Sow_DiffuseFinal.dds";
   diffuseMap[1] = "art/Textures/Animals/sow/SowNormalsFinal2.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};


singleton Material(Transitional_Mail_and_Plate_DIFFUSE_01_mat)
{
   mapTo = "Transitional_Mail_and_Plate_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/platemail/Transitional_Mail_and_Plate_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/platemail/Transitional_Mail_and_Plate_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/platemail/Transitional_Mail_and_Plate_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(HeavyScale_DIFFUSE_01_mat)
{
   mapTo = "HeavyScale_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/heavyscale/HeavyScale_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/heavyscale/HeavyScale_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/heavyscale/HeavyScale_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(RegularChain_DIFFUSE_01_mat)
{
   mapTo = "RegularChain_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/regularChain/RegularChain_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/regularChain/RegularChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/regularChain/RegularChain_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(Ironplate_DIFFUSE_01_mat)
{
   mapTo = "Ironplate_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/ironplate/Ironplate_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/ironplate/Ironplate_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/ironplate/IronPlate_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(LightScale_DIFFUSE_01_mat)
{
   mapTo = "LightScale_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/lightscale/LightScale_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/lightscale/LightScale_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/lightscale/LightScale_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(LightChain_DIFFUSE_02_mat)
{
   mapTo = "LightChain_DIFFUSE_02";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/LightChain/LightChain_DIFFUSE_02.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/LightChain/LightChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/LightChain/LightChain_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(Shovels_n_Picks_DIFFUSE_02_jpg_mat)
{
   mapTo = "Shovels_n_Picks_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Tools/Shovels_n_Picks_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Shovels_n_Picks_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Shovels_n_Picks_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Sickles_n_Hammers_DIFFUSE_01_jpg_mat)
{
   mapTo = "Sickles_n_Hammers_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Tools/Sickles_n_Hammers_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Sickles_n_Hammers_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Sickles_n_Hammers_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Swas_n_Pots_DIFFUSE_01_mat)
{
   mapTo = "Swas_n_Pots_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Tools/Swas_n_Pots_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Swas_n_Pots_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Swas_n_Pots_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Swas_n_Pots_DIFFUSE_01_jpg_mat)
{
   mapTo = "Swas_n_Pots_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Tools/Swas_n_Pots_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Swas_n_Pots_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Swas_n_Pots_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Add_Swords_DIFFUSE_02_jpg_mat)
{
   mapTo = "Add_Swords_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Add_Swords_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Add_Swords_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Add_Swords_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Add_Swords_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Add_Swords_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Add_Swords_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Add_Swords_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Add_Swords_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
   skinned = true;
};

singleton Material(RoyalChain_DIFFUSE_04_jpg_mat)
{
   mapTo = "RoyalChain_DIFFUSE_04.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/royalChain/RoyalChain_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/royalChain/RoyalChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/royalChain/RoyalChain_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(RoyalScale_DIFFUSE_03_jpg_mat)
{
   mapTo = "RoyalScale_DIFFUSE_03.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/royalScale/RoyalScale_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/royalScale/RoyalScale_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/royalScale/RoyalScale_SPECULAR_01.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "20";
   skinned = true;
};

singleton Material(RoyalPlate_Dark_01_jpg_mat)
{
   mapTo = "RoyalPlate_Dark_01.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/royalplate/RoyalPlate_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/royalplate/RoyalPlate_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/royalplate/RoyalPlate_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Mutton_ready_diff_mat)
{
   mapTo = "Mutton_ready_diff";
   diffuseMap[0] = "art/Textures/Animals/mutton/Mutton_ready_diff.dds";
   diffuseMap[1] = "art/Textures/Animals/mutton/Mutton_ready_normal.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Wolf_DIFFUSE_mat)
{
   mapTo = "Wolf_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/wolf/Wolf_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/wolf/Wolf_NORMAL.dds";
   diffuseMap[2] = "art/Textures/Animals/wolf/Wolf_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
};

singleton Material(Moose_DIFFUSE_mat)
{
   mapTo = "Moose_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/moose/mooze_diff2.dds";
   diffuseMap[1] = "art/Textures/Animals/moose/mooze_norm2.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Grouse_diff_fixed2_mat)
{
   mapTo = "Grouse_diff_fixed2";
   diffuseMap[0] = "art/Textures/Animals/grouse/Grouse_diff_fixed2.dds";
   diffuseMap[1] = "art/Textures/Animals/grouse/Grouse_nrm_fixed.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Rabbit_DIFFUSE_mat)
{
   mapTo = "Rabbit_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/hare/Rabbit_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/hare/Rabbit_NORMAL.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(RoyalLeather_DIFFUSE_02_jpg_mat)
{
   mapTo = "RoyalLeather_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/royalleather/RoyalLeather_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/royalleather/RoyalLeather_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/royalleather/RoyalLeather_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};


singleton Material(HeavyPadded_DIFFUSE_02_jpg_mat)
{
   mapTo = "HeavyPadded_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/heavypadded/HeavyPadded_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/heavypadded/HeavyPadded_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/heavypadded/HeavyPadded_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(RoyalPadded_DIFFUSE_BLACK_BROWN_02_jpg_mat)
{
   mapTo = "RoyalPadded_DIFFUSE_BLACK_BROWN_02.jpg";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/royalpadded/RoyalPadded_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/royalpadded/RoyalPadded_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/royalpadded/RoyalPadded_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(common_plant_herbal_plants_atlas)
{
   mapTo = "herbal_plants_atlas";
   diffuseMap[0] = "art/Textures/Atlas/herbal_plants_atlas_diff.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "LerpAlpha";
   diffuseMap[1] = "art/Textures/Atlas/herbal_plants_atlas_nm.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   translucent = "0";
   translucentZWrite = "0";
   alphaTest = "1";
   alphaRef = "13";
   materialTag0 = "LiF";
};

singleton Material(fountain_diff_mat)
{
   mapTo = "fountain_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fountain_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fountain_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/fountain_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(water_diff_mat)
{
   mapTo = "water_diff";
   diffuseMap[0] = "art/Textures/TextureLib/water_diff.dds";
   diffuseColor[0] = "0.996078 0.996078 0.996078 1";
   specular[0] = "0.8 0.972549 0.996078 1";
   specularPower[0] = "8";
   useAnisotropic[0] = "1";
   glow[0] = "1";
   emissive[0] = "1";
   doubleSided = "1";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 -0.31";
   scrollSpeed[0] = "0.824";
   translucent = "1";
   translucentZWrite = "1";
   alphaRef = "0";
   showFootprints = "0";
   showDust = "1";
   materialTag0 = "LiF";
   castShadows = "0";
};

singleton Material(fabric_diff_mat)
{
   mapTo = "fabric_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fabric_diff.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
   diffuseMap[1] = "art/Textures/TextureLib/fabric_nm.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(HeavyChain_DIFFUSE_01_mat)
{
   mapTo = "HeavyChain_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/heavyChain/HeavyChain_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/heavyChain/HeavyChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/heavyChain/HeavyChain_SPECULAR_01.dds";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(RoyalLeather_DIFFUSE_01_mat)
{
   mapTo = "RoyalLeather_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/royalleather/RoyalLeather_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/royalleather/RoyalLeather_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/royalleather/RoyalLeather_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(HeavyPadded_DIFFUSE_01_mat)
{
   mapTo = "HeavyPadded_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/heavypadded/HeavyPadded_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/heavypadded/HeavyPadded_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/heavypadded/HeavyPadded_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(RoyalChain_DIFFUSE_01_mat)
{
   mapTo = "RoyalChain_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/royalChain/RoyalChain_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/royalChain/RoyalChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/royalChain/RoyalChain_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(RoyalPlate_DIFFUSE_01_mat)
{
   mapTo = "RoyalPlate_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/royalplate/RoyalPlate_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/royalplate/RoyalPlate_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/royalplate/RoyalPlate_SPECULAR_01.dds";
   materialTag0 = "LiF";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(RoyalScale_DIFFUSE_01_mat)
{
   mapTo = "RoyalScale_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/royalScale/RoyalScale_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/royalScale/RoyalScale_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/royalScale/RoyalScale_SPECULAR_01.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "13";
   //envmap = true;
   //fChrome = 1;
   skinned = true;
};

singleton Material(male_blacksmith_diff_mat)
{
   mapTo = "male_blacksmith_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/male_blacksmith_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/male_blacksmith_norm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/male_blacksmith_spec.dds";
   doubleSided = "1";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(RoyalPadded_DIFFUSE_01_mat)
{
   mapTo = "RoyalPadded_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/royalpadded/RoyalPadded_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/royalpadded/RoyalPadded_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/royalpadded/RoyalPadded_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Forest_GC_tex_mat)
{
   mapTo = "Forest_GC_tex";
   diffuseMap[0] = "art/Textures/GroundCover/Forest.dds";
   diffuseMap[1] = "art/Textures/GroundCover/ForestNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/ForestSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   castShadows = "0";
   materialTag0 = "LiF";
   streamable = "0";
};

singleton Material(cog_diff_mat)
{
   mapTo = "cog_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cog_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cog_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_01_diff_mat)
{
   mapTo = "monument_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_01_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_02_diff_mat)
{
   mapTo = "monument_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_02_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_03_diff_mat)
{
   mapTo = "monument_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_03_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_03_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_04_diff_mat)
{
   mapTo = "monument_04_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_04_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_04_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_04_spec.dds";
   materialTag0 = "LiF";
};

singleton CubemapData(FairCubemap)
{
   cubeFace[0] = "art/2D/Skybox/FairSky/sky_Fair_Right.dds";
   cubeFace[1] = "art/2D/Skybox/FairSky/sky_Fair_Left.dds";
   cubeFace[2] = "art/2D/Skybox/FairSky/sky_Fair_Back.dds";
   cubeFace[3] = "art/2D/Skybox/FairSky/sky_Fair_Front.dds";
   cubeFace[4] = "art/2D/Skybox/FairSky/sky_Fair_Top.dds";
   cubeFace[5] = "art/2D/Skybox/FairSky/sky_Fair_Bottom.dds";
};

singleton CubemapData(DuskLightCubemap)
{
   cubeFace[0] = "art/2D/Skybox/DuskLight/sky_dusk_Right.dds";
   cubeFace[1] = "art/2D/Skybox/DuskLight/sky_dusk_Left.dds";
   cubeFace[2] = "art/2D/Skybox/DuskLight/sky_dusk_Back.dds";
   cubeFace[3] = "art/2D/Skybox/DuskLight/sky_dusk_Front.dds";
   cubeFace[4] = "art/2D/Skybox/DuskLight/sky_dusk_Top.dds";
   cubeFace[5] = "art/2D/Skybox/DuskLight/sky_dusk_Bottom.dds";
};

singleton CubemapData(DuskLight2Cubemap)
{
   cubeFace[0] = "art/2D/Skybox/DuskLight2/sky_dusk2_Right.dds";
   cubeFace[1] = "art/2D/Skybox/DuskLight2/sky_dusk2_Left.dds";
   cubeFace[2] = "art/2D/Skybox/DuskLight2/sky_dusk2_Back.dds";
   cubeFace[3] = "art/2D/Skybox/DuskLight2/sky_dusk2_Front.dds";
   cubeFace[4] = "art/2D/Skybox/DuskLight2/sky_dusk2_Top.dds";
   cubeFace[5] = "art/2D/Skybox/DuskLight2/sky_dusk2_Bottom.dds";
};

singleton CubemapData(NightCubemap)
{
   cubeFace[0] = "art/2D/Skybox/nightSky/skybox_1";
   cubeFace[1] = "art/2D/Skybox/nightSky/skybox_2";
   cubeFace[2] = "art/2D/Skybox/nightSky/skybox_3";
   cubeFace[3] = "art/2D/Skybox/nightSky/skybox_4";
   cubeFace[4] = "art/2D/Skybox/nightSky/skybox_5";
   cubeFace[5] = "art/2D/Skybox/nightSky/skybox_6";
};

singleton CubemapData(FoggyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/FoggySky/sky_Foggy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/FoggySky/sky_Foggy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/FoggySky/sky_Foggy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/FoggySky/sky_Foggy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/FoggySky/sky_Foggy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/FoggySky/sky_Foggy_Bottom.dds";
};

singleton CubemapData(SnowyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/SnowySky/Sky_Snowy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/SnowySky/Sky_Snowy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/SnowySky/Sky_Snowy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/SnowySky/Sky_Snowy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/SnowySky/Sky_Snowy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/SnowySky/Sky_Snowy_Bottom.dds";
};

singleton CubemapData(CloudyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/CloudySky/sky_Cloudy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/CloudySky/sky_Cloudy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/CloudySky/sky_Cloudy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/CloudySky/sky_Cloudy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/CloudySky/sky_Cloudy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/CloudySky/sky_Cloudy_Bottom.dds";
};

singleton Material(GC_Soil)
{
   mapTo = "_03";
   diffuseColor[0] = "0.733333 0.733333 0.733333 1";
   diffuseMap[0] = "art/Textures/GroundCover/Soil.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SoilNm.dds";
   castShadows = "0";
   alphaTest = "1";
   alphaRef = "60";
   showFootprints = "0";
   materialTag0 = "LiF_GC";
   doubleSided = "1";
   streamable = "0";
};

singleton Material(felling_02_diff_mat)
{
   mapTo = "felling_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/felling_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/felling_02_nm.dds";
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};


singleton Material(sack_03_diff_mat)
{
   mapTo = "sack_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/sack_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/sack_03_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(ancient_diff_mat)
{
   mapTo = "ancient_diff";
   diffuseMap[0] = "art/Textures/Atlas/ancient_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/ancient_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/ancient_spec.dds";
   materialTag0 = "LiF";
};


singleton Material(Throwing_Stuff_01_png_mat)
{
   mapTo = "Throwing_Stuff_01.png";
   diffuseMap[0] = "art/Textures/Weapons/Throwing_Stuff_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Throwing_Stuff_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Throwing_Stuff_SPECULAR_01.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Throwing_Stuff_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Throwing_Stuff_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Throwing_Stuff_DIFFUSE_01_skin.dds";
   diffuseMap[1] = "art/Textures/Weapons/Throwing_Stuff_NORMALMAP_01_skin.dds";
   diffuseMap[2] = "art/Textures/Weapons/Throwing_Stuff_SPECULAR_01_skin.dds";
   alphaTest = "1";
   alphaRef = "100";
   skinned = true;
};

singleton Material(cloth_trap_diff_mat)
{
   mapTo = "cloth_trap_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_trap_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_trap_nm.dds";
   alphaTest = "1";
   alphaRef = "10";
};

singleton Material(small_brick_01_diff_mat)
{
   mapTo = "small_brick_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/small_brick_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/small_brick_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/small_brick_01_spec.dds";
   specularPower[0] = "19";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};


singleton Material(fmrobe_mat)
{
   mapTo = "fmrobe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeD.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeN.dds";
   skinned = true;
};


singleton Material(TD_01_ThrowingKnife)
{
   mapTo = "ThrowingKnife";
   diffuseMap[0] = "Throwing_Stuff_DIFFUSE_01";
   translucentBlendOp = "None";
};

singleton Material(Face_Asia_Aneta_DIFFUSE_01_mat)
{
   mapTo = "Face_Asia_Aneta_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Face_Asia_Aneta_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Face_Asia_Aneta_NORMALMAP_01.dds";
   alphaTest = "1";
   alphaRef = "150";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(wood_floor_01_diff_mat2)
{
   mapTo = "wood_floor_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_floor_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_floor_01_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(skinnedcorpse_diff_mat)
{
   mapTo = "skinnedcorpse_diff";
   diffuseMap[0] = "art/Textures/TextureLib/skinnedcorpse_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/skinnedcorpse_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/skinnedcorpse_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(all_plants_diff_mat)
{
   mapTo = "all_plants_diff";
   diffuseMap[0] = "art/Textures/GroundCover/all_plants_diff.dds";
   diffuseMap[1] = "art/Textures/GroundCover/all_plants_nm.dds";
   doubleSided = "1";
   translucent = "0";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "30";
   streamable = "0";
   normalsUp = "1";
};

singleton Material(planks_03_diff_mat)
{
   mapTo = "planks_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/planks_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/planks_02_nm.dds";
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
};

singleton Material(moss_diff_mat)
{
   mapTo = "moss_diff";
   diffuseMap[0] = "art/Textures/TextureLib/moss_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/moss_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "218";
   doubleSided = "1";
};

singleton Material(Decal_Streaks_diff_mat)
{
   mapTo = "Decal_Streaks_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_Streaks_diff.dds";
   translucent = "1";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   castShadows = "1";
   alphaTest = "1";
   alphaRef = "134";
   doubleSided = "1";
};

singleton Material(Moss_Log_diff_mat)
{
   mapTo = "Moss_Log_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Moss_Log_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Moss_Log_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "94";
   doubleSided = "1";
};

singleton Material(roof_tile_mat)
{
   mapTo = "roof_tile";
   diffuseMap[0] = "art/Textures/TextureLib/roof_tile_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/roof_tile_nm.dds";
};

singleton Material(Decal_Lichens_diff_mat)
{
   mapTo = "Decal_Lichens_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_Lichens_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Decal_Lichens_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "193";
   translucent = "0";
   castShadows = "0";
};

singleton Material(Decal_HangingIvy_diff_mat)
{
   mapTo = "Decal_HangingIvy_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_HangingIvy_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Decal_HangingIvy_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Decal_HangingIvy_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "132";
   translucent = "0";
   translucentBlendOp = "None";
   doubleSided = "1";
};

singleton Material(cloth_01_diff_mat)
{
   mapTo = "cloth_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_01_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "132";
   translucent = "0";
   translucentBlendOp = "None";
   doubleSided = "1";
};

singleton Material(glass_diff_mat)
{
   mapTo = "glass_diff";
   diffuseMap[0] = "art/Textures/TextureLib/glass_diff.dds";
   diffuseMap[2] = "art/Textures/TextureLib/glass_spec.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
   alphaTest = "1";
   doNotZWrite = "1";
};

singleton Material(glass_broken_diff_mat)
{
   mapTo = "glass_broken_diff";
   diffuseMap[0] = "art/Textures/TextureLib/glass_broken_diff.dds";
   translucentBlendOp = "AddAlpha";
   alphaTest = "1";
   alphaRef = "9";
   materialTag0 = "LiF";
   doubleSided = "1";
   translucent = "1";
};

singleton Material(tombstone_01_diff_mat)
{
   mapTo = "tombstone_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/tombstone_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/tombstone_01_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(tombstone_02_diff_mat)
{
   mapTo = "tombstone_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/tombstone_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/tombstone_02_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(wood_roof_01_alpha_diff_mat)
{
   mapTo = "wood_roof_01_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_roof_01_alpha_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_roof_01_alpha_nm.dds";
   materialTag0 = "LiF";
   specularPower[0] = "38";
   pixelSpecular[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "242";
};

singleton Material(wood_roof_01_alpha_diff_mat)
{
   mapTo = "wood_roof_01_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_roof_01_alpha_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_roof_01_alpha_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "242";
};

singleton Material(fakhverk_atlas_02_diff_mat)
{
   mapTo = "fakhverk_atlas_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/fakhverk_atlas_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fakhverk_atlas_02_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(House_detail_atlas_1_diff_mat)
{
   mapTo = "House_detail_atlas_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/House_detail_atlas_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/House_detail_atlas_1_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "134";
   materialTag0 = "LiF";
};


singleton Material(House_plants_01_diff_mat)
{
   mapTo = "House_plants_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/House_plants_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/House_plants_01_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "67";
};

singleton Material(Rope_2_diff_mat)
{
   mapTo = "Rope_2_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_2_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_2_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
};

singleton Material(roof_tile_2_alpha_diff_mat)
{
   mapTo = "roof_tile_2_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/roof_tile_2_alpha_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/roof_tile_2_alpha_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "238";
   specularPower[0] = "38";
   pixelSpecular[0] = "1";
};

singleton Material(rBlast_mat)
{
   mapTo = "rBlast";
  diffuseMap[0] = "art/decals/rBlast.dds";
   doubleSided = "1";
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
};

singleton Material(stone_big_angle_diff_mat)
{
   mapTo = "stone_big_angle_diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_big_angle_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_big_nm.dds";
   materialTag0 = "LiF";
   diffuseMap[2] = "art/Textures/TextureLib/stone_big_spec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
};

singleton Material(Rope_1_diff_mat)
{
   mapTo = "Rope_1_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_1_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_1_nm.dds";
   materialTag0 = "LiF";
};
singleton Material(Rope_1_skinned_diff_mat)
{
   mapTo = "Rope_1_skinned_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_1_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_1_nm.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(robe_D_male_mat)
{
   mapTo = "robe_D";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/male/robe_D.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/male/robe_N.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/male/robe_S.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Decal_Mud_diff_mat)
{
   mapTo = "Decal_Mud_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_Mud_diff.dds";
   translucent = "1";
   materialTag0 = "LiF";
   castShadows = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

singleton Material(throne_diff_mat)
{
   mapTo = "throne_diff";
   diffuseMap[0] = "art/Textures/TextureLib/throne_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/throne_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/throne_spec.dds";
};

singleton Material(herbal_plants_atlas_diff_mat)
{
   mapTo = "herbal_plants_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/herbal_plants_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/herbal_plants_atlas_nm.dds";
   alphaTest = "1";
   alphaRef = "87";
};

singleton Material(Rock_diff_mat)
{
   mapTo = "Rock_diff";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock/Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock/Rock_nm.dds";
   normal3DC="1";
   materialTag0 = "LiF";
};

singleton Material(Rock_diff_mat_v2)
{
   mapTo = "rock_diff";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock/Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock/Rock_nm.dds";
   normal3DC="1";
   materialTag0 = "LiF";
};

singleton Material(brick_3_mat)
{
   mapTo = "brick_3";
   diffuseMap[0] = "art/Textures/TextureLib/brick_2.png";
   diffuseMap[1] = "art/Textures/TextureLib/brick_2_normal.png";
};

singleton Material(wall_metal_mat)
{
   mapTo = "wall_metal";
   diffuseMap[0] = "art/Textures/TextureLib/wall_metal.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wall_metal_normal.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wall_metal_spec.dds";
};

singleton Material(brick_2_mat)
{
   mapTo = "brick_2";
   diffuseMap[0] = "art/Textures/TextureLib/brick_2.dds";
   diffuseMap[1] = "art/Textures/TextureLib/brick_2_normal.dds";
   materialTag0 = "LiF";
};

singleton Material(Trebushet_atlas_01_diff_mat)
{
   mapTo = "Trebushet_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_01_spec.dds";
   skinned = true;
};

singleton Material(Trebushet_atlas_02_diff_mat)
{
   mapTo = "Trebushet_atlas_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_02_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_02_spec.dds";
   skinned = true;
};

singleton Material(Trebushet_planks_01_diff_mat)
{
   mapTo = "Trebushet_planks_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_01_spec.dds";
   skinned = true;
};

singleton Material(Trebushet_planks_02_diff_mat)
{
   mapTo = "Trebushet_planks_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_02_spec.dds";
   skinned = true;
};

singleton Material(Metall_atlas_01_diff_mat)
{
   mapTo = "Metall_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/Metall_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Metall_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Metall_atlas_01_spec.dds";
   materialTag0 = "LiF";
   translucent = "0";
   alphaTest = "1";
   alphaRef = "93";
};

singleton Material(Metall_atlas_01_skinned_diff_mat)
{
   mapTo = "Metall_atlas_01_skinned_diff";
   diffuseMap[0] = "art/Textures/Atlas/Metall_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Metall_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Metall_atlas_01_spec.dds";
   materialTag0 = "LiF";
   translucent = "0";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
};

singleton Material(Trebushet_planks_02_diff_nonskinned_mat)
{
   mapTo = "Trebushet_planks_02_diff_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_02_spec.dds";
   alphaTest = "1";
   alphaRef = "20";
};

singleton Material(Trebushet_atlas_02_diff_nonskinned_mat)
{
   mapTo = "Trebushet_atlas_02_diff_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_02_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_02_spec.dds";
   alphaTest = "1";
   alphaRef = "46";
};

singleton Material(Trebushet_planks_01_diff_nonskinned_mat)
{
   mapTo = "Trebushet_planks_01_diff_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_01_spec.dds";
};

singleton Material(Metall_atlas_01_diff_nonskinned_mat)
{
   mapTo = "Metall_atlas_01_diff_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/Metall_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Metall_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Metall_atlas_01_spec.dds";
   alphaTest = "1";
   alphaRef = "46";
};

singleton Material(grenade_diff_mat)
{
   mapTo = "grenade_diff";
   diffuseMap[0] = "art/Textures/Weapons/grenade_diff.dds";
   diffuseMap[1] = "art/Textures/Weapons/grenade_nm.dds";
   diffuseMap[2] = "art/Textures/Weapons/grenade_spec.dds";
};

singleton Material(fishnet_diff_mat)
{
   mapTo = "fishnet_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fishnet_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fishnet_nm.dds";
   specularPower[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "40";
};

singleton Material(shops_03_atlas_diff_mat)
{
   mapTo = "shops_03_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/shops_03_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_03_atlas_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops_03_atlas_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(wooden_sign_diff_mat)
{
   mapTo = "wooden_sign_diff";
   diffuseMap[0] = "art/Textures/Atlas/wooden_sign_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/wooden_sign_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/wooden_sign_spec.dds";
   alphaTest = "1";
   alphaRef = "94";
};

singleton Material(WindowGrille_diff_mat)
{
   mapTo = "WindowGrille_diff";
   diffuseMap[0] = "art/Textures/Atlas/WindowGrille_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WindowGrille_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WindowGrille_spec.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(shops_04_atlas_diff_mat)
{
   mapTo = "shops_04_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/shops_04_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_04_atlas_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops_04_atlas_spec.dds";
   materialTag0 = "LiF";
   translucent = "1";
};

singleton Material(Fence_diff_mat)
{
   mapTo = "Fence_diff";
   diffuseMap[0] = "art/Textures/Atlas/Fence_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Fence_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Fence_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Fence_02_diff_mat)
{
   mapTo = "Fence_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/Fence_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fence_02_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/fence_02_spec.dds";
   materialTag0 = "LiF";
};

//-----------------------------------------------------------------------------
// LOD100 Atlas
//-----------------------------------------------------------------------------

singleton Material(LOD100_house_atlas_01_mat)
{
   mapTo = "LOD100_house_atlas_01";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_house_atlas_01.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
   alphaTest = "1";
   alphaRef = "101";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_02_mat)
{
   mapTo = "LOD100_atlas_02";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_02.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_03_mat)
{
   mapTo = "LOD100_atlas_03";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_03.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "90";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_04_mat)
{
   mapTo = "LOD100_atlas_04";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_04.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_05_mat)
{
   mapTo = "LOD100_atlas_05";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_05.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(LOD100_residence_atlas_01_mat)
{
   mapTo = "LOD100_residence_atlas_01";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_residence_atlas_01.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
   alphaTest = "1";
   alphaRef = "101";
   doubleSided = "1";
};

singleton Material(lods_atlas_mat)
{
   mapTo = "lods_atlas";
   diffuseMap[0] = "art/Textures/Atlas/lods_atlas.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "80";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_wooden_fortification_mat)
{
   mapTo = "LOD100_atlas_wooden_fortification";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_wooden_fortification.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

//-----------------------------------------------------------------------------
// HORSES --- START
//-----------------------------------------------------------------------------

singleton Material(Normal_Horse_base_mat)
{
   mapTo = "base.normal_horse";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Normal_Horse_black_mat)
{
   mapTo = "black.normal_horse";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BLACK_01_mat)
{
   mapTo = "Horse_DIFFUSE_BLACK_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Normal_Horse_brown_mat)
{
   mapTo = "brown.normal_horse";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BROWN_01_mat)
{
   mapTo = "Horse_DIFFUSE_BROWN_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_base_mat)
{
   mapTo = "base.skinny_horse";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_bw_mat)
{
   mapTo = "bw.skinny_horse";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BW_01_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BW_01";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_brown_mat)
{
   mapTo = "brown.skinny_horse";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BROWN_01_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BROWN_01";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse_base_mat)
{
   mapTo = "base.heavy_horse";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse1_DIFFUSE_01_mat)
{
   mapTo = "Heavy_Horse1_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse_clr2_mat)
{
   mapTo = "clr2.heavy_horse";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse2_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse2_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse2_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse2_DIFFUSE_01_mat)
{
   mapTo = "Heavy_Horse2_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse2_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse2_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse2_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse_clr3_mat)
{
   mapTo = "clr3.heavy_horse";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse3_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse3_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse3_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse3_DIFFUSE_01_mat)
{
   mapTo = "Heavy_Horse3_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse3_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse3_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse3_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

//-----------------------------------------------------------------------------
// HORSES --- END
//-----------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------БОРОДЫ, ВОЛОСЫ, ГОЛОВЫ, ТЕЛА------------------------------------------------------------------
//---------------------------------------------------------МУЖСКОГО ПЕРОНАЖА-------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------


//-------------------------------------------------------------БОРОДЫ------------------------------------------------------------------------


singleton Material(Male_Beard_All_v2_DIFFUSE_mat)//Борода 2
{
   mapTo = "Male_Beard_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v2_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v4_DIFFUSE_mat2)//Борода 4
{
   mapTo = "Male_Beard_All_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v3_DIFFUSE_mat)//Борода евро 3
{
   mapTo = "Male_Beard_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Mon_v3_DIFFUSE_mat)//Борода монгольская 3
{
   mapTo = "Male_Beard_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Mon_v4_DIFFUSE_mat)//Борода монгольская 4
{
   mapTo = "Male_Beard_Mon_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};


singleton Material(Male_Beard_Vik_v1_DIFFUSE_mat)//Борода викинга 1
{
   mapTo = "Male_Beard_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v4_DIFFUSE_mat)//Борода викинга 4
{
   mapTo = "Male_Beard_Vik_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_Mon_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v1_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_Mon_v2_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_Vik_v2_DIFFUSE_mat)//Борода викинга 2
{
   mapTo = "Male_Beard_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v3_DIFFUSE_mat)//Борода викинга 3
{
   mapTo = "Male_Beard_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v3_DIFFUSE_mat)
{
   mapTo = "Male_Beard_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v4_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};



//------------------------------------------------------------ВОЛОСЫ------------------------------------------------------

singleton Material(Male_Hair_All_v1_DIFFUSE_mat) //мужская прическа 1
{
   mapTo = "Male_Hair_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v2_DIFFUSE_mat) //мужская прическа 2
{
   mapTo = "Male_Hair_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v4_DIFFUSE_mat) //мужская прическа 4
{
   mapTo = "Male_Hair_All_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v1_DIFFUSE_mat) //мужская евро прическа 1
{
   mapTo = "Male_Hair_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v2_DIFFUSE_mat) //мужская монгольская прическа 2
{
   mapTo = "Male_Hair_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v4_DIFFUSE_mat) //мужская монгольская прическа 4
{
   mapTo = "Male_Hair_Mon_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(Male_Hair_Vik_v2_DIFFUSE_mat) //мужская прическа викингов 1
{
   mapTo = "Male_Hair_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Eur_v4_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};


singleton Material(Male_Hair_Mon_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v3_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Vik_v1_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Vik_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Vik_v4_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v4_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};


singleton Material(Male_Hair_All_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   doubleSided = "1";
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v1_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};


//------------------------------------------------------------ГОЛОВЫ-----------------------------------------------------

singleton Material(Male_Head_Eur_v1_DIFFUSE_mat)//Муж. европейская голова v1
{
   mapTo = "Male_Head_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Head_Mon_v1_DIFFUSE_mat)//Муж. монгольская голова v1
{
   mapTo = "Male_Head_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Head_Vik_v1_DIFFUSE_mat)//Муж. голова викинга v1
{
   mapTo = "Male_Head_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};



singleton Material(Male_Head_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
   useCustomColor = true;
   useAnisotropic[0] = "1";
   isFace = true;
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Mon_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Vik_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Vik_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};




singleton Material(Male_Head_Eur_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Mon_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


//-------------------------------------------------------------ТЕЛА-----------------------------------------------------------

singleton Material(Male_Body_v1_DIFFUSE_mat)//Муж. тело v1
{
   mapTo = "Male_Body_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   useCustomColor = true;
   isBody = true;
   useAnisotropic[0] = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

    // Customization
   customizationData[0]  = Custom_Male_Body_Tatoo_1;
   customizationData[1]  = Custom_Male_Body_Tatoo_2;
   customizationData[2]  = Custom_Male_Body_Tatoo_3;
   customizationData[3]  = Custom_Male_Body_Tatoo_4;
   customizationData[4]  = Custom_Male_Body_Tatoo_5;
   customizationData[5]  = Custom_Male_Body_Tatoo_6;
   customizationData[6]  = Custom_Male_Body_Tatoo_7;
   customizationData[7]  = Custom_Male_Body_Tatoo_8;
   customizationData[8]  = Custom_Male_Body_Paint_v1;
   customizationData[9]  = Custom_Male_Body_Paint_v2;
   customizationData[10]  = Custom_Male_Body_Scar_v1;
   customizationData[11]  = Custom_Male_Body_Scar_v2;
   customizationData[12]  = Custom_Male_Body_Scar_v3;
   customizationData[13]  = Custom_Male_Body_Scar_v4;
   customizationData[14]  = Custom_Male_Body_Scar_v5;
};



//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------








//-----------------------------------------------------ЛОХМОТЬЯ--------------------------------------------------------

singleton Material(Male_Tatters_Vik_DIFFUSE_mat)//Викинги
{
   mapTo = "Male_Tatters_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Vik_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Tatters_Mon_DIFFUSE_mat)//Монголы
{
   mapTo = "Male_Tatters_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Mon_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

//-----------------------------------------------------НИЖНЕЕ БЕЛЬЕ--------------------------------------------------

singleton Material(Male_Underwear_Eur_DIFFUSE_mat)//Муж. нижнее бельё
{
   mapTo = "Male_Underwear_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Antiseam_DIFFUSE_mat)//Рубаха
{
   mapTo = "Male_Antiseam_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


//----------------------------------------------------MALE OUTFITS----------------------------------------------------------

singleton Material(Male_Craft90_All_Carpenter_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Carpenter_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Decorated_DIFFUSE_mat)
{
   mapTo = "Male_Decorated_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Blacksmith_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Blacksmith_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Peasant_Male_DIFFUSE_mat)
{
   mapTo = "Peasant_Male_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(Male_Tatters_Eur_DIFFUSE_mat)
{
   mapTo = "Male_Tatters_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Eur_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Engineer_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Engineer_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Cook_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Cook_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Alchemist_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Alchemist_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(table_stuff_diff_mat)
{
   mapTo = "table_stuff_diff";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Male_Monk_DIFFUSE_mat)
{
   mapTo = "Male_Monk_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(GM_Robe_DIFFUSE_mat)
{
   mapTo = "GM_Robe_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "73";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Male_Peasant_DIFFUSE_mat)
{
   mapTo = "Male_Peasant_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Blacksmith_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Blacksmith_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   alphaRef = "87";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Mkrestiane_mat) //Simple Male
{
   mapTo = "Mkrestiane";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Mkrestiane.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/MkrestianeN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/MkrestianeS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(MnishiyD_mat) //Rags Male
{
   mapTo = "MnishiyD";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/rags/MnishiyD.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/rags/MnishiyN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/rags/MnishiyS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Weapon_Pack_04_DIFFUSE_02_jpg_mat)
{
   mapTo = "Weapon_Pack_04_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_02.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_02.dds";
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_mat)
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

//---------------------------------------------------------------------------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Construction materials
//-----------------------------------------------------------------------------

singleton Material(table_stuff_diff_mat)
{
   mapTo = "table_stuff_diff";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   alphaTest = "1";
   alphaRef = "57";
};

singleton Material(Weaving_basket_diff_mat)
{
   mapTo = "Weaving_basket_diff";
   diffuseMap[0] = "art/Textures/Atlas/Weaving_basket_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Weaving_basket_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Weaving_basket_spec.dds";
   doubleSided = "1";
};

singleton Material(Planks_atlas_diff_mat)
{
   mapTo = "Planks_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/Planks_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Planks_atlas_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Planks_atlas_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(WatchFire01)
{
   mapTo = "WatchFire01";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/TextureLib/WatchFire01_Diffuse.dds";
   specular[0] = "0.392157 0.388235 0.207843 1";
   specularPower[0] = "25";
   diffuseMap[1] = "art/Textures/TextureLib/WatchFire01_Normal.dds";
   diffuseMap[12] = "art/Textures/TextureLib/WatchFire01_Emissive.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="0.2";
   emissionIntensityMax="0.8";
   alphaTest = "1";
   alphaRef = "111";
   pixelSpecular[0] = "1";
};

singleton Material(VillageOven_diffuse_mat)
{
   mapTo = "VillageOven_diffuse";
   diffuseMap[0] = "art/Textures/Atlas/VillageOven_diffuse.dds";
   diffuseMap[1] = "art/Textures/Atlas/VillageOven_normal.dds";
   diffuseMap[2] = "art/Textures/Atlas/VillageOven_specular.dds";
   materialTag0 = "LiF";
};

singleton Material(VillageOven_dmg_mat)
{
   mapTo = "VillageOven_dmg";
   diffuseMap[0] = "art/Textures/Atlas/VillageOven_dmg_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/VillageOven_dmg_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/VillageOven_dmg_spec.dds";
   alphaTest = "1";
   alphaRef = "111";
   materialTag0 = "LiF";
};

singleton Material(Oven_diff_mat)
{
   mapTo = "Oven_diff";
   diffuseMap[0] = "art/Textures/Atlas/Oven_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Oven_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Oven_spec.dds";
   materialTag0 = "LiF";
   alphaRef = "1";
};

singleton Material(DoorsAtlas_01_diff_mat)
{
   mapTo = "DoorsAtlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/DoorsAtlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/DoorsAtlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/DoorsAtlas_01_spec.dds";
   useAnisotropic[0] = "1";
};

singleton Material(Mats_atlas_1_diff_mat)
{
   mapTo = "Mats_atlas_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/Mats_atlas_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Mats_atlas_1_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Mats_atlas_1_spec.dds";
};

singleton Material(Blind_atlas_1_diff_mat)
{
   mapTo = "Blind_atlas_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/Blind_atlas_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Blind_atlas_1_nm.dds";
};

singleton Material(WoodenColumns_diff_mat)
{
   mapTo = "WoodenColumns_diff";
   diffuseMap[0] = "art/Textures/TextureLib/WoodenColumns_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/WoodenColumns_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/WoodenColumns_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(Shutters_diff_mat)
{
   mapTo = "Shutters_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Shutters_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Shutters_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Shutters_spec.dds";
};

singleton Material(Doorjamb_diff_mat)
{
   mapTo = "Doorjamb_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Doorjamb_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Doorjamb_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Doorjamb_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(FellingInterior_diff_mat)
{
   mapTo = "FellingInterior_diff";
   diffuseMap[0] = "art/Textures/TextureLib/FellingInterior_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/FellingInterior_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/FellingInterior_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   pixelSpecular[0] = "0";
};

singleton Material(FellingExterior_diff_mat)
{
   mapTo = "FellingExterior_diff";
   diffuseMap[0] = "art/Textures/TextureLib/FellingExterior_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/FellingExterior_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/FellingExterior_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   pixelSpecular[0] = "0";
};

singleton Material(glass_no_alpha_diff_mat)
{
   mapTo = "glass_no_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/glass_no_alpha_diff.dds";
};

singleton Material(lockers_diff_mat)
{
   mapTo = "lockers_diff";
   diffuseMap[0] = "art/Textures/Atlas/lockers_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/lockers_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/lockers_spec.dds";
};

singleton Material(woodenTables_diff_mat)
{
   mapTo = "woodenTables_diff";
   diffuseMap[0] = "art/Textures/Atlas/woodenTables_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/woodenTables_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/woodenTables_spec.dds";
};

singleton Material(chairsChests_diff_mat)
{
   mapTo = "chairsChests_diff";
   diffuseMap[0] = "art/Textures/Atlas/chairsChests_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/chairsChests_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/chairsChests_spec.dds";
};

singleton Material(bedSmall_diff_mat)
{
   mapTo = "bedSmall_diff";
   diffuseMap[0] = "art/Textures/Atlas/bedSmall_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/bedSmall_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/bedSmall_spec.dds";
};

singleton Material(Torch_diff_mat)
{
   mapTo = "Torch_diff";
   diffuseMap[0] = "art/Textures/Tools/Torch_diff.dds";
   diffuseMap[1] = "art/Textures/Tools/Torch_nm.dds";
   diffuseMap[2] = "art/Textures/Tools/Torch_spec.dds";
   diffuseMap[12] = "art/Textures/Tools/Torch_emiss.dds";
   alphaTest = "1";
   alphaRef = "33";
   emission="1";
   emissionIntensityFreq="0.6";
   emissionIntensityMin="3";
   emissionIntensityMax="8";
};

   singleton Material(Sacks_1_diff_mat)
{
   mapTo = "Sacks_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/Sacks_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Sacks_1_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Sacks_1_spec.dds";
   alphaTest = "1";
   alphaRef = "67";
   doubleSided = "1";
};

singleton Material(Rope_3_diff_mat)
{
   mapTo = "Rope_3_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_3_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_3_nm.dds";
   alphaTest = "0";
   alphaRef = "0";
};

singleton Material(tableBenchest_diff_mat)
{
   mapTo = "tableBenchest_diff";
   diffuseMap[0] = "art/Textures/Atlas/tableBenchest_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/tableBenchest_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/tableBenches_spec.dds";
};

singleton Material(beds_diff_mat)
{
   mapTo = "beds_diff";
   diffuseMap[0] = "art/Textures/Atlas/beds_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/beds_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/beds_spec.dds";
};

singleton Material(SignsForChests_diff_mat)
{
   mapTo = "SignsForChests_diff";
   diffuseMap[0] = "art/Textures/Atlas/SignsForChests_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/SignsForChests_nm.dds";
};

singleton Material(shops_02_atlas_DiffAlpha_mat)
{
   mapTo = "shops_02_atlas_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/shops_02_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_02_atlas_nm.dds";
   alphaTest = "1";
   alphaRef = "87";
};

singleton Material(shops_01_atlas_DiffAlpha_mat)
{
   mapTo = "shops_01_atlas_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/shops-01-atlas-diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops-01-atlas-nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops-01-atlas-spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "140";
};

singleton Material(table_stuff_DiffAlpha_mat)
{
   mapTo = "table_stuff_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   diffuseMap[12] = "art/Textures/Atlas/table_stuff_emiss.dds";
   alphaTest = "1";
   alphaRef = "109";
   emission="1";
   emissionIntensityFreq="0.8";
   emissionIntensityMin="0.6";
   emissionIntensityMax="2";
};

singleton Material(WindowGrille_DiffAlpha_mat)
{
   mapTo = "WindowGrille_DiffAlpha";
   diffuseMap[0] = "art/Textures/TextureLib/WindowGrille_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/WindowGrille_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/WindowGrille_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "56";
};

singleton Material(wooden_sign_DiffAlpha_mat)
{
   mapTo = "wooden_sign_DiffAlpha";
   diffuseMap[0] = "art/Textures/TextureLib/wooden_sign_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wooden_sign_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wooden_sign_spec.dds";
   alphaTest = "1";
   alphaRef = "94";
   materialTag0 = "LiF";
};

singleton Material(Tomb_diff_mat)
{
   mapTo = "Tomb_diff";
   diffuseMap[0] = "art/Textures/Atlas/Tomb_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Tomb_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Tomb_spec.dds";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

singleton Material(Diff_mat)
{
   mapTo = "Diff";
   diffuseMap[0] = "art/Textures/Atlas/SackA_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/SackA_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/SackA_spec.dds";
   alphaTest = "1";
   alphaRef = "154";
   doubleSided = "1";
};

singleton Material(SackA_diff_mat)
{
   mapTo = "SackA_diff";
   diffuseMap[0] = "art/Textures/Atlas/SackA_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/SackA_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/SackA_spec.dds";
   alphaTest = "1";
   alphaRef = "134";
   doubleSided = "1";
};

singleton Material(KiteShield_Horse_DIFFUSE_01_mat)
{
   mapTo = "KiteShield_Horse_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/KiteShield_Horse_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/KiteShield_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/KiteShield_Horse_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(wall_atlas_diff_mat)
{
   mapTo = "wall_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/wall_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/wall_atlas_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "10";
};


singleton Material(Wood_atlas_01_diff_mat)
{
   mapTo = "Wood_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/Wood_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Wood_atlas_normal_diff.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(Plow_diff_mat)
{
   mapTo = "Plow_diff";
   diffuseMap[0] = "art/Textures/Atlas/Plow_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Plow_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Plow_spec.dds";
};

singleton Material(TorchSpade_diff_mat)
{
   mapTo = "TorchSpade_diff";
   diffuseMap[0] = "art/Textures/Atlas/TorchSpade_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/TorchSpade_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/TorchSpade_spec.dds";
   alphaTest = "1";
   alphaRef = "60";
   doubleSided = "1";
};

singleton Material(flags_diff_mat)
{
   mapTo = "flags_diff";
   diffuseMap[0] = "art/Textures/TextureLib/flags_gloss.dds";
   diffuseMap[1] = "art/Textures/TextureLib/flags_norm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/flags_spec.dds";
   alphaTest = "1";
   alphaRef = "93";
   useAnisotropic[0] = "1";
   isArmor = true;
   skinned = true;
   doubleSided = "1";
   heraldicCustomizationData = Flag_Heraldry;
   
};

singleton Material(Log_mat)
{
   mapTo = "Log";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/TextureLib/Log_Diffuse.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Log_Normal.dds";
   specularPower[0] = "50";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(Trebushet_atlas_01_diff_nonskinned_mat)
{
   mapTo = "Trebushet_atlas_01_diff_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_01_spec.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Bear_Diffuse_nonskinned_mat)
{
   mapTo = "Bear_Diffuse_nonskinned";
   diffuseMap[0] = "art/Textures/Animals/bear/Bear_Diffuse_nonskinned.dds";
   diffuseMap[1] = "art/Textures/Animals/bear/Bear_Normals_nonskinned.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "80";
};

singleton Material(Deer_Diffuse_nonskinned_mat)
{
   mapTo = "Deer_Diffuse_nonskinned";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_deco_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_deco_Normal.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(mooze_diff2_nonskinned_mat)
{
   mapTo = "mooze_diff2_nonskinned";
   diffuseMap[0] = "art/Textures/Animals/moose/mooze_deco_diff2.dds";
   diffuseMap[1] = "art/Textures/Animals/moose/mooze_deco_norm2.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "60";
};

singleton Material(sickles_n_hammers_diffuse_01_nonskinned_mat)
{
   mapTo = "sickles_n_hammers_diffuse_01_nonskinned";
   diffuseMap[0] = "art/Textures/Tools/Sickles_n_Hammers_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Sickles_n_Hammers_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Sickles_n_Hammers_SPECULAR_01.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "0";
   translucent = "1";
};

singleton Material(Bull_Male_DIFFUSE_mat)
{
   mapTo = "Bull_Male_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bull/Bull_Male_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
};

singleton Material(wooden_floor_mat)
{  mapTo = "wooden_floor";
   diffuseMap[0] = "art/Textures/TextureLib/wooden_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wooden_floor_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wooden_floor_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(fabric_diff_skin_mat)
{
   mapTo = "fabric_diff_skin";
   diffuseMap[0] = "art/Textures/TextureLib/fabric_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fabric_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
};

singleton Material(wood_diffuce_01_skin_mat)
{
   mapTo = "wood_diffuce_01_skin";
   diffuseMap[0] = "art/Textures/TextureLib/wood_diffuce_01.dds";
};

singleton Material(LOD100_atlas_03_skin_mat)
{
   mapTo = "LOD100_atlas_03_skin";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_03.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "167";
   doubleSided = "1";
};

singleton Material(Cow_whizbang_diffuse_mat)
{
   mapTo = "Cow_whizbang_diffuse";
   diffuseMap[0] = "art/Textures/Animals/Cow/Cow_diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Cow/Cow_Normals.dds";
   skinned = true;
};

singleton Material(WoodRoofB_diff_mat)
{
   mapTo = "WoodRoofB_diff";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoofB_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoofB_nm.dds";
   diffuseMap[3] = "art/Textures/Atlas/WoodRoofB_spec.dds";
   specularPower[0] = "1";
   specularStrength[0] = "0.5";
   materialTag0 = "LiF";
};

//--------------------------Снеговики---------------------------------

singleton Material(snowman_A_mat)
{
   mapTo = "snowman_A";
   diffuseMap[0] = "art/Textures/Atlas/snowman_A_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_B_mat)
{
   mapTo = "snowman_B";
   diffuseMap[0] = "art/Textures/Atlas/snowman_B_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_C_mat)
{
   mapTo = "snowman_C";
   diffuseMap[0] = "art/Textures/Atlas/snowman_C_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_С_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_D_mat)
{
   mapTo = "snowman_D";
   diffuseMap[0] = "art/Textures/Atlas/snowman_D_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_E_mat)
{
   mapTo = "snowman_E";
   diffuseMap[0] = "art/Textures/Atlas/snowman_E_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(RegularChain_DIFFUSE_01_nonskinned_mat)
{
   mapTo = "RegularChain_DIFFUSE_01_nonskinned";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/regularChain/RegularChain_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/regularChain/RegularChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/regularChain/RegularChain_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(sprucet_nonskinned)
{
   mapTo = "sprucet_nonskinned";
   diffuseMap[0] = "art/Models/3D/Environment/Trees/spruce/images/diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_spruce_diff.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
   materialTag0 = "LiF";
};

singleton Material(Throwing_Stuff_DIFFUSE_01_jpg_mat)
{
   mapTo = "Throwing_Stuff_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Throwing_Stuff_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Throwing_Stuff_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Throwing_Stuff_SPECULAR_01.dds";
   alphaTest = "1";
   alphaRef = "93";
};

singleton Material(snowballs_mat)
{  mapTo = "snowballs";
   diffuseMap[0] = "art/Textures/Atlas/snowballs_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
};


singleton Material(snowball_diff_mat)
{
   mapTo = "snowball_diff";
   diffuseMap[0] = "art/Textures/Atlas/snowball_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowball_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowball_spec.dds";
};

singleton Material(alchemy_box_mat)
{  mapTo = "alchemy_box";
   diffuseMap[0] = "art/Textures/Atlas/alchemy_box_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/alchemy_box_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/alchemy_box_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "67";
   doubleSided = "1";
};

singleton Material(clay_dishes_A_mat)
{  mapTo = "clay_dishes_A";
   diffuseMap[0] = "art/Textures/Atlas/clay_dishes_A_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/clay_dishes_A_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/clay_dishes_A_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(alchemy_box_ground_mat)
{  mapTo = "alchemy_box_ground";
   diffuseMap[0] = "art/Textures/TextureLib/alchemy_box_ground_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/alchemy_box_ground_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/alchemy_box_ground_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(stone_stair_comp_mat)
{  mapTo = "stone_stair_comp";
   diffuseMap[0] = "art/Textures/Atlas/stone_stair_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/stone_stair_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/stone_stair_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(stone_stair_dmg_mat)
{  mapTo = "stone_stair_dmg";
   diffuseMap[0] = "art/Textures/Atlas/stone_stair_dmg_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/stone_stair_dmg_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/stone_stair_dmg_spec.dds";
   materialTag0 = "LiF";
};


//-----------------------------ЛУКИ И АРБАЛЕТЫ--------------------------------------------------------------------

singleton Material(Weapon_Pack_07_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Weapon_Pack_07_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_07_DIFFUSE_01_skin.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_07_NORMALMAP_01_skin.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_07_SPECULAR_01_skin.dds";
   skinned = true;
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01_skin.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01_skin.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01_skin.dds";
   skinned = true;
};

// Tabards
singleton Material(Surcoat_armor_DIFFUSE_mat)
{
   mapTo = "Surcoat_armor_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Surcoat/Surcoat_armor_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Surcoat/Surcoat_armor_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Surcoat/Surcoat_armor_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "100";
   useAnisotropic[0] = "1";
   isTabard = true;
   skinned = true;
   doubleSided = "1";
   heraldicCustomizationData = Surcoat_Armor_Heraldry;
};

singleton Material(Surcoat_Body_DIFFUSE_mat)
{
   mapTo = "Surcoat_Body_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Surcoat/Surcoat_Body_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Surcoat/Surcoat_Body_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Surcoat/Surcoat_Body_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   useAnisotropic[0] = "1";
   isTabard = true;
   skinned = true;
   doubleSided = "1";
   heraldicCustomizationData = Surcoat_Body_Heraldry;
};

singleton Material(Buckler_DIFFUSE_01_jpg_mat)
{
   mapTo = "Buckler_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Shields/Buckler_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/Buckler_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/Buckler_SPECULAR_01.dds";
   translucentBlendOp = "None";
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(PrimitiveShield_DIFFUSE_02_jpg_mat)
{
   mapTo = "PrimitiveShield_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Shields/PrimitiveShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/PrimitiveShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/PrimitiveShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   isHeraldic = "0";
   isArmor = "1";
};

//Щиты для геральдики

singleton Material(KiteShield_EXPORT_01_KiteShield_DIFFUSE_01)
{
   mapTo = "KiteShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/KiteShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/KiteShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/KiteShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = KiteShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(HeaterShield_EXPORT_01_HeaterShield_DIFFUSE_01)
{
   mapTo = "HeaterShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/HeaterShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/HeaterShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/HeaterShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = HeaterShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(PaviseShield_EXPORT_01_PaviseShield_DIFFUSE_01)
{
   mapTo = "PaviseShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/PaviseShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/PaviseShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/PaviseShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = PaviseShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(PrimitiveShield_EXPORT_01_PrimitiveShield_DIFFUSE_01)
{
   mapTo = "PrimitiveShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/PrimitiveShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/PrimitiveShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/PrimitiveShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = PrimitiveShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(RoundShield_EXPORT_01_RoundShield_DIFFUSE_01)
{
   mapTo = "RoundShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/RoundShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/RoundShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/RoundShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = RoundShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(SteelRoundache_EXPORT_01_SteelRoundache_DIFFUSE_01)
{
   mapTo = "SteelRoundache_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/SteelRoundache_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/SteelRoundache_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/SteelRoundache_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = SteelRoundacheHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(TowerShield_EXPORT_01_TowerShield_DIFFUSE_01)
{
   mapTo = "TowerShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/TowerShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/TowerShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/TowerShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = TowerShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

// Материалы новго wooden keep

singleton Material(WoodRoof_diff_mat)
{
   mapTo = "WoodRoof_diff";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoof_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoof_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WoodRoof_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Woodbalks_diff_mat)
{
   mapTo = "Woodbalks_diff";
   diffuseMap[0] = "art/Textures/Atlas/Woodbalks_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Woodbalks_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Woodbalks_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(PlanksA_diff_mat)
{
   mapTo = "PlanksA_diff";
   diffuseMap[0] = "art/Textures/Atlas/PlanksA_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/PlanksA_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/PlanksA_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(InteriorElements_diff_mat)
{
   mapTo = "InteriorElements_diff";
   diffuseMap[0] = "art/Textures/Atlas/InteriorElements_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/InteriorElements_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/InteriorElements_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Balcony_diff_mat)
{
   mapTo = "Balcony_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Balcony_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Balcony_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Balcony_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(PlanksB_diff_mat)
{
   mapTo = "PlanksB_diff";
   diffuseMap[0] = "art/Textures/Atlas/PlanksB_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/PlanksB_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/PlanksB_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(WoodRoof_diff_no_snow_mat)
{
   mapTo = "WoodRoof_diff_no_snow";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoof_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoof_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WoodRoof_spec.dds";
   materialTag0 = "LiF";
};



//______________________________


exec("art/female_materials.cs");
exec("art/materials_environment.cs");
