using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace ParakeetBrain
{
    public class ParakeetBrainInfo : GH_AssemblyInfo
    {
        public override string Name => "ParakeetBrain";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("45762455-0076-473f-bfbf-ea786cbf3c52");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}