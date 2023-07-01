# GenshinStudio
Check out the [original AssetStudio project](https://github.com/Perfare/AssetStudio) for more information.

This is the release of GenshinStudio, Modded AssetStudio that should work with Genshin Impact/YuanShen.

Note: Requires Internet connection to fetch asset_index jsons.
_____________________________________________________________________________________________________________________________

Some features are:
```
- BLK/CAB methods support.
- Integration with `Radioegor146` repo to load asset_index through `Options -> Specify AI version`.
- Exportable Assets (not all of them) with XOR/JSON support for `MiHoYoBinData`
- Togglable debug console.
- Container/filename recovery for Assets.
```
_____________________________________________________________________________________________________________________________
How to use:

CAB Method:
```
1. Extract blks to a specific location (File -> Extract folder).
2. Build CAB Map (Misc. -> Build CABMap).
3. Load CAB files.
```
BLK Method:
```
1. Build BLK Map (Misc. -> Build BLKMap).
2. Load BLK files.
```

NOTE: in case of any `MeshRenderer/SkinnedMeshRenderer` errors, make sure to enable `Disable Renderer` option in `Export Options` before loading assets.

Looking forward for feedback for issues/bugs to fix and update.
_____________________________________________________________________________________________________________________________
Special Thank to:
- Khang06: [genshinblkstuff](https://github.com/khang06/genshinblkstuff) for blk/mhy0 extraction.
- Radioegor146: [gi-asset-indexes](https://github.com/radioegor146/gi-asset-indexes) for recovered/updated asset_index's.
- Ds5678: [AssetRipper](https://github.com/AssetRipper/AssetRipper)[[discord](https://discord.gg/XqXa53W2Yh)] for information about Asset Formats & Parsing.
