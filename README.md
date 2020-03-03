
# Unity 2D Template

## About

This Unity template was made in 2019.3.0f6



## Tutorial

From [unity-user-guide](https://github.com/Zeyu-Li/unity-user-guide)

[2D](#2D)

* [General](#2dg)
* [Sprites](#spr)
* [Movement](#move)
* Pixelated



<a name="2D"></a>

### Chapter 4. 2D

<a name="2dg"></a>

#### 4a General

So you've decide to make a 2D game. Great! Who needs modelling and lighting (It's a lot of work anyways)? 

2D games are secretly 3D, what does that mean? Think of Unity 2D as a bunch of layers like in Photoshop, Gimp, After Effects, or Illustrator. The closest to the camera is picked up first and blocks the ones behind it. As a 2D world, lighting is global (unless you want enable an experimental local lighting feature). To start a new 2D game, click **New** and select 2D on the pop-up screen and use the desired directory (or follow my cloning [guide](#guide) so to not start from starch). This may take some time, but after Unity finishes installing itself, we can get started. Now let's make a player and make it move!

*Note, part of the tutorial (2D) follows this [repo](https://github.com/Zeyu-Li/Unity-Template-2D-2019_3): [Unity-Template-2D-2019_3](https://github.com/Zeyu-Li/Unity-Template-2D-2019_3)

<a name="spr"></a>

#### 4b Sprites

Sprites are what make up the visuals of the game. These could be png or jpeg (recommended because of small size) file. You can make your own and drag them into an **Artworks folder**.

If you have multiple sprites on a picture file, you have what is called a sprite sheet. These could be useful because it saves space. Unity comes with a sprite editor that can cut the sprite sheet into multiple sprites. 

However, before we get to that, let us take a look at the Sprite setting

![sprites](file://C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/sprites.png?lastModify=1583275182)

From the top header, we can see some info on the item

From the header we also see:

- Texture Type - Usually will only use sprite (2D image) or normal map (for 3D depth)
- Sprite mode - as single texture or sprite sheet
  - Adjust the pixels per unit (Pixels per unit should be 1-1) (In my case, it is 360 px per tile)
  - Pivot - where the center of object is
- Wrap Mode - how the image is displayed (ie repeated or clamped(/cut) at the board)  
- Filter Mode - Point (equivalent to pixel perfect or nearest neighbour in Photoshop) or Bilinear (natural scaling with edge softening)
- Format - Format of image (8bit, 16 bit, 32 bit colour with or without alpha)

*Note, if a setting was not mentioned, it is not that important at the beginner level.

**Multiple Sprites**

1. Select Multiple in **Sprite Mode**

2. Click **Spirit Editor** button

   ![spriteEditor](file://C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/spriteEditor.png?lastModify=1583275182)

3. In sprite editor, click Slice -> Slice (This is an automatic slicer and is usually good enough, if not, manually move the transform bound boxes to fit or define split at distance apart (must change to **Grid by Size Count**, not **Automatic**) with the size of tile in **Pixel Size**.

4. Click apply

5. Close window or drag to some widget

6. You can inspect every tile by expanding the original image and a bunch of tiles with name pictureName_0 to # of tiles with be a child of it

Now, with a sprite, you can drag it into the scene

To create a tile map, follow the following:

1. GameObject -> 2D Object -> Tile Map
2. Open Tile Palette, by going to Window -> 2D -> Tile Palette
3. Create New Palette and save it
4. Drag all individual tiles into widget or drag parent spritesheet (and save)



Now with the tile palette, you can draw on the scene, reorganize everything and many other things

![tilePalette](file://C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/tilePalette.png?lastModify=1583275182)

From the top, there are many icons, we will go through each of them

- Curser - selects tiles from scene
- Move - Moves tiles in palette (Only if you click **Edit**)
- Brush - paints on scene
- Square/Rect - Selects multiple tiles or one to paint from
- Eye dropper - Selects tile from scene
- Eraser - Erases
- Paint Bucket - Floods with active brush (Like Photoshop)

Resources: [Brackeys](https://www.youtube.com/watch?v=ryISV_nH8qw)

<a name="move"></a>

#### 4c Movement

Movement is critical in all games, whether the movement is limited to left or right, or games that in 3D. On the internet there are may sources that claim the perfect jump, but only you can decide that based on the gameplay. 

To start off with, make a new folder of scripts



## Layout

* _RawFileAssets - use this to store program files, i.e. psd, ai files, etc. OR mp3, png, that may or may not be the final product
* Assets - What Unity sees
* Anything else - Don't touch

## Controls

* Use A, W, D keys to move

## Licence

The rules for copy and distributing this project licence are
outlined in the licence.txt file.

This project is under an MIT licence

## Engine used

* Unity

