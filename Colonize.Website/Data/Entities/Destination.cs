﻿using System;

namespace Colonize.Website.Data.Entities
{
    public class Destination
    {
        public Destination(int id, string name, string description, Uri imageUrl)
            : this(name, description, imageUrl)
        {
            Id = id;
        }

        public Destination(string name, string description, Uri imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Uri ImageUrl { get; protected set; }
    }
}