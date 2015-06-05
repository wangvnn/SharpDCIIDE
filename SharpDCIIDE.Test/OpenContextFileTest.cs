using KimHaiQuang.SharpDCIIDE.Presentation.Operation;
using NJasmine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDCIIDE.Test
{
    public class OpenContextFileTest : GivenWhenThenFixture
    {
        public void BeforeAll()
        {

        }
        public void AfterAll()
        {

        }
        public void BeforeEach()
        {

        }
        public void AfterEach()
        {

        }
        public override void Specify()
        {
            beforeAll(BeforeAll);
            afterAll(AfterAll);

            beforeEach(BeforeEach);
            afterEach(AfterEach);

            given("User selected a Context file", () =>
            {
                string contextfile = ""; 

                when("User wants to view the Context File in Editor", () =>
                {

                    then("win!", () =>
                    {
                        //expect(() => range == 11);
                    });
                });
            });
        }
    }
}
