﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Матулевскаяпр16
{
    public partial class Friend
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override bool Equals(object obj)
        {
            Friend friend = obj as Friend;
            return this.Id == friend.Id;
        }

    }
}