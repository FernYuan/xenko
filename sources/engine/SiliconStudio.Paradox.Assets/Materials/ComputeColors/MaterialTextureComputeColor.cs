// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;

namespace SiliconStudio.Paradox.Assets.Materials.ComputeColors
{
    /// <summary>
    /// A color texture node.
    /// </summary>
    [DataContract("MaterialTextureComputeColor")]
    [Display("Texture")]
    public class MaterialTextureComputeColor : MaterialTextureComputeNodeBase, IMaterialComputeColor
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MaterialTextureComputeColor()
            : base(null, TextureCoordinate.Texcoord0, Vector2.One, Vector2.Zero)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialTextureComputeColor" /> class.
        /// </summary>
        /// <param name="texturePath">Name of the texture.</param>
        /// <param name="texcoordIndex">Index of the texcoord.</param>
        /// <param name="scale">The scale.</param>
        /// <param name="offset">The offset.</param>
        public MaterialTextureComputeColor(string texturePath, TextureCoordinate texcoordIndex, Vector2 scale, Vector2 offset)
            : base(texturePath, texcoordIndex, scale, offset)
        {
        }

        protected override string GetTextureChannelAsString()
        {
            // Use all channels
            return "rgba";
        }
    }
}
