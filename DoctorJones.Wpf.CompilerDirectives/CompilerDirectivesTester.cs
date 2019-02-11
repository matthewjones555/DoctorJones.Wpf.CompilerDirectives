using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorJones.Wpf.CompilerDirectives
{
    public static class CompilerDirectivesTester
    {
        public static string TestCompilerDirectives()
        {
#if NET20
            return "Target framework: NET20";
#elif NET35
            return "Target framework: NET35";
#elif NET40
            return "Target framework: NET40";
#elif NET45
            return "Target framework: NET45";
#elif NET451
            return "Target framework: NET451";
#elif NET452
            return "Target framework: NET452";
#elif NET46
            return "Target framework: NET46";
#elif NET461
            return "Target framework: NET461";
#elif NET462
            return "Target framework: NET462";
#elif NET47
            return "Target framework: NET47";
#elif NET471
            return "Target framework: NET471";
#elif NET472
            return "Target framework: NET472";
#elif NETSTANDARD1_0
            return "Target framework: NETSTANDARD1_0";
#elif NETSTANDARD1_1
            return "Target framework: NETSTANDARD1_1";
#elif NETSTANDARD1_2
            return "Target framework: NETSTANDARD1_2";
#elif NETSTANDARD1_3
            return "Target framework: NETSTANDARD1_3";
#elif NETSTANDARD1_4
            return "Target framework: NETSTANDARD1_4";
#elif NETSTANDARD1_5
            return "Target framework: NETSTANDARD1_5";
#elif NETSTANDARD1_6
            return "Target framework: NETSTANDARD1_6";
#elif NETSTANDARD2_0
            return "Target framework: NETSTANDARD2_0";
#elif NETCOREAPP1_0
            return "Target framework: NETCOREAPP1_0";
#elif NETCOREAPP1_1
            return "Target framework: NETCOREAPP1_1";
#elif NETCOREAPP2_0
            return "Target framework: NETCOREAPP2_0";
#elif NETCOREAPP2_1
            return "Target framework: NETCOREAPP2_1";
#elif NETCOREAPP2_2
            return "Target framework: NETCOREAPP2_2";
#else
            return "Target framework: NOT_DEFINED";
#endif
        }
    }
}
