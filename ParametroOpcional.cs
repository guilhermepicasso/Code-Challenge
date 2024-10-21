using System;

namespace EstudoSharp
{
    class ParametroOpcional
    {
        public ParametroOpcional()
        {


            string[] guestList = { "Guilherme", "Pedro", "Lucas", "Marcelo" };
            string[] rsvps = new string[10];
            int count = 0;

            RSVP_Event("Guilherme");
            RSVP_Event("Pedro", 2, "Nuts");
            RSVP_Event(name: "Linh", partySize: 2, inviteOnly: false);
            RSVP_Event("Tony", allergies: "Jackfruit", inviteOnly: true);
            RSVP_Event("Lucas", 4, inviteOnly: false);
            RSVP_Event("Marcelo", 2, "Stone fruit", false);
            Show();

            void RSVP_Event(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
            {
                if (inviteOnly)
                {
                    bool found = false;
                    foreach (string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void Show()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }
            }

        }
    }
}
