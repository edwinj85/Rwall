﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rwall.Shared
{
    /// <summary>
    /// This class stores const strings and ints so we can avoid magic numbers etc.
    /// </summary>
    public static class Consts
    {
        public const String AppName = "Rwall";

        public const String DefaultSubreddit = "Wallpapers";

        public const String AppErrorMessageTitle = "Rwall Error";

        public const String CannotConnectErrorMessage = "Cannot connect to www.reddit.com, do you have a working network connection?";

        public const String WallpaperStyleRegKey = "WallpaperStyle";

        public const String TileWallpaperRegKey = "TileWallpaper";

        public const String TiledStyleWallpaperStyleRegValue = "1";

        public const String TiledStyleTileWallpaperRegValue = "1";

        public const String CenteredStyleWallpaperStyleRegValue = "1";

        public const String CenteredStyleTileWallpaperRegValue = "0";

        public const String StretchedStyleWallpaperStyleRegValue = "2";

        public const String StretchedStyleTileWallpaperRegValue = "0";

        public const String NoWallpapersFoundErrorMessage = "No images found for that subreddit. Are you sure it exists?";

        /// <summary>
        /// The root domain of Imgur - this string should always be lower case for easy comparisons.
        /// </summary>
        public const String ImgurDotCom = "imgur.com";

        /// <summary>
        /// If an imgur link contains this URL is is an albumn, NOT an image!
        /// </summary>
        public const String ImgurAlbumString = "/a/";

        /// <summary>
        /// If an imgur link contains this URL is is an gallery, NOT an image!
        /// </summary>
        public const String ImgurGalleryString = "/gallery/";

        /// <summary>
        /// This character appended on any imgur URL (before the file extension) will return a smaller preview of that image (l == large preview).
        /// Should always be lower case for easy comparisons.
        /// </summary>
        public const char ImgurLargePreviewApiChar = 'l';

        /// <summary>
        /// The length of an imgur id, 7 characters. If it has 8 or more, it is a preview etc.
        /// </summary>
        public static Int32 ImgurIdLength = 7;

        /// <summary>
        /// The number to divide a window width/height by to make sure we always have 20 wallpapers on screen on any resize. (5 columns x 4 rows)
        /// </summary>
        public const Int32 WallpaperColumnSize = 6;

        /// <summary>
        /// The maximum amount of request items reddit will return to us at once without an error.
        /// </summary>
        public const Int32 MaxWallpapersPerRequest = 100;

        /// <summary>
        /// The amount of wallpapers we intend to show on screen per request.
        /// </summary>
        public const Int32 WallpapersToDisplayPerRequest = 20;
    }
}
