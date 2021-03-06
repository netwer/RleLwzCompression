﻿using System;
using System.Collections.Generic;
using System.IO;
using RleLwzCompressionLibrary.Algorithms.Interfaces;
using RleLwzCompressionLibrary.Exceptions;
using RleLwzCompressionLibrary.Models;

namespace RleLwzCompressionLibrary.Algorithms.Realisations
{
    public class Rle : IAlgorithmsCompression
    {
        public Picture Encode(Picture picture)
        {
            try
            {
                var pictureInbytes = File.ReadAllBytes(picture.Path);
                Picture encodedPicture = new Picture
                {
                    EncodedContents = new List<string>(),
                    Name = picture.Name,
                    Path = picture.Path
                };

                for (int i = 0; i < pictureInbytes.Length; i++)
                {
                    byte currentBytesCount = 1;
                    while (currentBytesCount < byte.MaxValue && i + 1 < pictureInbytes.Length &&
                           pictureInbytes[i] == pictureInbytes[i + 1])
                    {
                        currentBytesCount++;
                        i++;
                    }
                    encodedPicture.EncodedContents.Add(currentBytesCount.ToString());
                    encodedPicture.EncodedContents.Add(pictureInbytes[i].ToString());
                }
                encodedPicture.Size = encodedPicture.EncodedContents.Count;
                return encodedPicture;
            }
            catch (Exception e)
            {
                throw new AlgorithmsException(e.Message,e);
            }
        }

        public Picture Decode(Picture picture)
        {
            try
            {
                var decodedPicture = picture;
                decodedPicture.DecodedContents = new List<byte>();
                for (int i = 1; i < picture.EncodedContents.Count; i += 2)
                {
                    byte currentBytesCount = Convert.ToByte(picture.EncodedContents[i - 1]);
                    while (currentBytesCount > 0)
                    {
                        decodedPicture.DecodedContents.Add(Convert.ToByte(picture.EncodedContents[i]));
                        currentBytesCount--;
                    }
                }
                decodedPicture.Size = decodedPicture.DecodedContents.Count;
                return decodedPicture;
            }
            catch (Exception e)
            {
                throw new AlgorithmsException(e.Message,e);
            }
        }
    }
}
