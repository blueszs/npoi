
/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace TestCases.DDF
{

    using System;

    using NUnit.Framework;using NUnit.Framework.Legacy;
    using NPOI.DDF;
    using NPOI.Util;
    [TestFixture]
    public class TestEscherBoolProperty
    {
        [Test]
        public void TestToString()
        {
            EscherBoolProperty p = new EscherBoolProperty((short)1, 1);
            ClassicAssert.AreEqual("propNum: 1, RAW: 0x0001, propName: unknown, complex: False, blipId: False, value: 1 (0x00000001)", p.ToString());
        }

    }
}