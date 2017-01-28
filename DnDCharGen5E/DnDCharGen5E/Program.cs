using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            /* The races for DND Characters */
            string[] races = new string[] { "Alleozsa", "Aloii", "Alraune", "Alu-Fiend", "Amazonian", "Anansi", "Angel", "Animated Armor", "Anthrolupe", "Antilonoid", "Apeling", "Aquarion", "Aqueous", "Arachne", "Aran-iods", "Arborens",
                "Avariel", "Avariel Elf", "Azer", "Baketako", "Barbed Devil", "Barraki", "Bearon", "Beeforged", "Beholder", "Birali", "Bladeling", "Blood Angel", "Blueveined", "Blugruim", "Bone Splinter", "Bugbear", "Bulbon",
                "Bullywug", "Cartura", "Castoran", "Catfolk", "Cauzerauti", "Centaur", "Changeling", "Chattur", "Chibido", "Chicken", "Chimeran", "Chiropterans", "Chosen Undead", "Cleansed Blight", "Clugs", "Concubus",
                "Corrupted", "Cyclops", "Dantise", "Dark Aberrations", "Death Qaz", "Demigod", "Derro", "Devilkin", "Dhampir", "Dnilb", "Doppelganger", "Dracon", "Draconic Elf", "Dragon Elf", "Dragonfolk", "Dragovian",
                "Drakin", "Drakoniant", "Drakyn", "Drock-Yar", "Eberron Goblin", "Eldrazi", "Elementling", "Elf Orc", "Elftaur", "Elven Nymph", "Embodied Mouther", "Erinyes", "Fairykind", "Fary", "Flora Colossus",
                "Floran", "Flumph", "Font Skeleton", "Forest Golem", "Formicid", "Fragor Magnus", "Frezia Clan", "Frosk", "Gadragger", "Galapian", "Galeb Duhr", "Gargoyle", "Geist", "Genie", "Gesttil", "Ghost", "Ghoul",
                "Giantkin", "Giff", "Gillman", "Gith", "Glass Angel", "Gnoll", "Goble", "Goblin", "Godzilla", "Goliath Panda", "Grassland Warrior", "Grauel Kemono", "Guardian Construct", "Hadozee", "Half-Basilisk", "Half-Breed",
                "Half-Dryad", "Half-Giant", "Half-Gnome", "Half-Kitsune", "Half-Minotaur", "Half-Oni", "Half-Troll", "Half-hag", "Half-Ghost", "Half-Dwarf", "Harpy", "Hellcat", "Hircus", "Hog Folk", "Homeblessed", "Hominapium",
                "Homo Superior", "Hound Archon", "Hydronian", "Hyperion", "Iceheart", "Ikuisuus", "Illithid", "Imp", "Incubus", "Irotori", "Jackalfolk", "Jupotes", "Karakuri", "Kasama", "Kender", "Kenku", "Khajiit", "Kitsune",
                "Kobold", "Kra Maghull", "Kreen", "Kri", "Krogan", "Kryptonian", "Ktropo", "Kumakin", "Kuo-Toa", "Lamia", "Lapine", "Lead Face", "Leprechaun", "Lionfolk", "Lisen", "Litch", "Living Artifice", "Living Toon",
                "Lizardfolk", "Lombax", "Lost", "Lost Men", "Loxodon", "MAchine Doll", "Magmin", "Magnagrada", "Majmun", "Mammuthari", "Marunae", "Meick", "Meltskin", "Memeites", "Merfolk", "Metalborn", "Mewmans", "Mikoto",
                "Mimic", "Minotaur", "Mitocabra", "Mobian", "Modron", "Mogogol", "Mongrelfolk", "Monrel", "Moon Fey", "Mousefolk", "Mudcrawler", "Mummy", "Mutantfolk", "Myconid", "Neko", "Nephil", "Nephili", "Nerubian",
                "Nescerei", "Njutco", "Not Dwarf", "Novakid", "Ogrillon", "Oni", "Ooze-kin", "Oozeling", "Orc", "Orch", "Orctaur", "Otterfolk", "Para Genasi", "Phantomborn", "Phoelarch", "Phykke", "Pillar Men", "Pnevma",
                "Polar Owl", "Priaced", "Protean", "Prothean", "Quaggoth",  "Rabbitfolk", "Rag Doll", "Rakshia", "Ratfolk", "Rhino Folk", "River-Devil", "Roba", "Roc Roc", "S'Tek", "Suhuagin", "Saiyan", "Sasquatch", "Satyr",
                "Sciurian", "Scorpikis", "Seafolk", "Selachinoid", "Selkie", "Shade blood", "Shadow Charmer", "Shardkin", "Shardmind", "Sidhe", "Silmarin", "Skeksis", "Skeleton", "Slann", "Slime People", "Slimelings", "Sliver",
                "Slyvarian", "Solaire", "Sorath", "Soul Stitched", "Space Pirate", "Spectral", "Spiderfolk", "Spirit of Intellect", "Spynkazaka", "Stonepeople", "Stormborn", "Succubus", "Suva", "Sa", "Tanarukk", "Tempest",
                "Tenno", "Tevi", "The Devoid", "Therianthrope", "Thri-Kreen", "Tiefling", "Tigerfolk", "Titas", "Tortle", "Treefolk", "Trichadons", "Troglodyte", "Trollkin", "Tsukumogami", "Tusquarian", "Twili", "UnderCreature",
                "Undine", "Vampire", "Varana", "Vidreans", "Viera", "Voidling", "Volki", "Vulpin", "War Born", "Warforged", "Wargen", "Water Monkey", "Wayang", "Werewolf", "Wolfborn", "Wolffolk", "Xenomorph", "Xortan",
                "Yalu", "Yetifolk", "Zaa'Hraa", "Zardak", "Zen'Trath"};

            /* The genders for DND Characters */
            string[] gender = new string[] { "Male", "Female" };

            /* The classes for DND Characters */
            string[] classes = new string[] { "Adrenaline Manipulator", "Aquasorcerer", "Acrane Tinkerer", "Arcane Warrior", "Arcanist", "Armament Mage", "Armed With Wings", "Artificer", "Assasin", "Aura Guardian", "Battle Medic",
                "Battlemind", "Beast Friend", "Beastmaster", "Berserker", "Blackguard", "Blacklight Mutator", "Blade Mage", "Blade Savant", "Blood Beserker", "Blood Mage", "Bloodborne Hunter", "Blue Mage", "Bone Breaker",
                "Bounty Hunter", "Bright Lord", "Card Dealer", "Celestial Conduit", "Channeler", "Chronomancer", "Conjurer", "Conquistador", "Corsair", "Cryomancer", "Cuisiner", "Curseslinger", "Dagger Master", "Daring Swashbuckler",
                "Dark Knight", "Dark Lord", "Dark Meister", "Death Dealer", "Death Knight", "Death Magus", "Deciever", "Deck Master", "Deity Bound", "Demigod", "Demolitionist", "Demon Hunter", "Demonic Assassin", "Dirge",
                "Drafter", "Dragon", "Dragon Knight", "Dragon Rider", "Dragon Slayer", "Dread Fighter", "Elemental Assassin", "Elemental Mage", "Elementalist", "Enkindler", "Fae Fang", "Fencing Magician", "Fury", "Fused Warrior",
                "GEO", "Galvanizer", "Godbound", "Godzilla", "Gravity Knight", "Guardian Construct", "Gunslinger", "Healer", "Hellblazer", "Hemomancer", "Heroic Spirit", "Holy Avenger", "Human Puppet", "Hunter", "Imperial Guardsmen",
                "Imperial Warder", "Inventor", "Kenpachi", "Keybearer", "Keyblade Wielder", "Ki Fighter", "Knight", "Lord of Void", "Luchador", "Mage", "Mageblade", "Magic Gambler", "Magic Girl", "Master of Ceremonies", "Mech Master",
                "Mechanist", "Mechromancer", "Meme Master", "Mesmer", "Metaphysicalist", "Mime", "Momentum Warrior", "Monk of the Outer Plane", "Monster MAster", "Mountain", "Muqatil", "Nature Champion", "Necrodancer", "Nordic",
                "One Trick Pony", "Overlord", "Pegasus Knight", "Personifier", "Phase Warrior", "Physicist", "Pious Samarai", "Pirate", "Player", "Primal Fighter", "Primal Hunter", "Primitive Hunter", "Psi-Stalker", "Psion",
                "Psionic", "Psychic", "Psychopath", "Puppet", "Pyromancer", "Ranger", "Ravager", "Reflectionist", "Rider", "Rune Space Demolitionist", "Runecannon", "Runepriest", "Runeseeker", "Samurai", "Satan Spawn", "Shadow Assasin",
                "Shadow Hunter", "Shadow Thief", "Shadowblade", "Shadowcaster", "Shadowsoul", "Shaman", "Shapechanger", "Shield Master", "Shrine Maiden", "Skald", "Sky Mage", "Slaughterer", "Soul Reaper", "Soul Warden",
                "Soulguard", "Soulknife", "Speeder", "Speedster", "Spellfire Wielder", "Stand User", "Storm Mage", "Storyteller", "Student", "Summoner", "Super Soldier", "Swashbuckler", "Swift's Inquisitor", "Synergist", "Tactician",
                "Tempest Knight", "Tenki Knight", "The Gentlemen", "Transmutation Alchemist", "Truenamer", "Umbramancer", "Untouchable Blade", "Valkrym", "Valkyrie", "Vampire", "Vampire Slayer", "Vanguard", "Vigilante", "Vitamancer",
                "Warcaster", "Warrior of Fenris", "Weapon Master", "Windwalker", "Woad Warrior", "Wraith Blade", "Wyvern", "Xilan Warrior", "Yellow Sun Kryptonian", "Zephyr", "Zombie"
                };

            /* Alignment-1 for DND Characters */
            string[] alignone = new string[] { "Good", "Neutral", "Evil" };

            /* Alignment-2 for DND Characters */
            string[] aligntwo = new string[] { "Lawful", "Neutral", "Chaotic" };

            Console.Write("Race: "+races[random.Next(0, races.Length)] + "\n");
            Console.Write("Class: " + classes[random.Next(0, classes.Length)] + "\n");
            Console.Write("Gender: " + gender[random.Next(0, gender.Length)] + "\n");
            Console.Write("Alignment: " + aligntwo[random.Next(0, aligntwo.Length)] + " " + alignone[random.Next(0, alignone.Length)] + "\n");
            Console.Write("Strength: " + random.Next(3, 18) + "\n");
            Console.Write("Dexterity: " + random.Next(3, 18) + "\n");
            Console.Write("Constitution: " + random.Next(3, 18) + "\n");
            Console.Write("Intelligence: " + random.Next(3, 18) + "\n");
            Console.Write("Wisdom: " + random.Next(3, 18) + "\n");
            Console.Write("Charisma: " + random.Next(3, 18) + "\n");
            Console.Write("Type anything to exit... \n");
            Console.ReadLine();
        }
    }
}
