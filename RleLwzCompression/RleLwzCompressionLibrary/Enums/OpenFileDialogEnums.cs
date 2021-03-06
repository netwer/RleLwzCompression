﻿using RleLwzCompressionLibrary.Enums.Attributes;

namespace RleLwzCompressionLibrary.Enums
{
    public enum OpenFileDialogEnums
    {
        [EnumDisplay("JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif")]
        Filter,
        [EnumDisplay("Please select an image file to test.")]
        Title
    }
}
