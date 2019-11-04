﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchGenerator {
  static public class wordSelections {

    static public string randomLetterList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-'0987654321";

    static public string L_fryFirstHundred = "about, all, an, and, are, as, at, be, been, but, by, called, can, come, could, day, did, do, down, each, find, first, for, from, get, go, had, has, have, he, her, him, his, how, if, in, into, is, it, like, long, look, made, make, many, may, more, my, no, not, now, number, of, oil, on, one, or, other, out, part, people, said, see, she, sit, so, some, than, that, the, their, them, then, there, these, they, this, time, to, two, up, use, was, water, way, we, were, what, when, which, who, will, with, words, would, write, you, your";
    static public string L_fryFirstFiveHundred = "about, all, an, and, are, as, at, be, been, but, by, called, can, come, could, day, did, do, down, each, find, first, for, from, get, go, had, has, have, he, her, him, his, how, if, in, into, is, it, like, long, look, made, make, many, may, more, my, no, not, now, number, of, oil, on, one, or, other, out, part, people, said, see, she, sit, so, some, than, that, the, their, them, then, there, these, they, this, time, to, two, up, use, was, water, way, we, were, what, when, which, who, will, with, words, would, write, you, your, after, again, air, also, America, animal, another, answer, any, around, ask, away, back, because, before, big, boy, came, change, different, does, end, even, follow, form, found, give, good, great, hand, help, here, home, house, just, kind, know, land, large, learn, letter, line, little, live, man, me, means, men, most, mother, move, much, must, name, need, new, off, old, only, our, over, page, picture, place, play, point, put, read, right, same, say, sentence, set, should, show, small, sound, spell, still, study, such, take, tell, things, think, three, through, too, try, turn, us, very, want, well, went, where, why, work, world, years, above, add, almost, along, always, began, begin, being, below, between, book, both, car, carry, children, city, close, country, cut, don’t, earth, eat, enough, every, example, eyes, face, family, far, father, feet, few, food, four, girl, got, group, grow, hard, head, hear, high, idea, important, Indian, it’s, keep, last, late, leave, left, let, life, light, list, might, mile, miss, mountains, near, never, next, night, often, once, open, own, paper, plant, real, river, run, saw, school, sea, second, seem, side, something, sometimes, song, soon, start, state, stop, story, talk, those, thought, together, took, tree, under, until, walk, watch, while, white, without, young, across, against, area, become, best, better, birds, black, body, certain, cold, color, complete, covered, cried, didn’t, dog, door, draw, during, early, easy, ever, fall, farm, fast, field, figure, fire, fish, five, friends, ground, happened, heard, himself, hold, horse, hours, however, hundred, I’ll, king, knew, listen, low, map, mark, measure, money, morning, music, north, notice, numeral, order, passed, pattern, piece, plan, problem, products, pulled, questions, reached, red, remember, rock, room, seen, several, ship, short, since, sing, slowly, south, space, stand, step, sun, sure, table, today, told, top, toward, town, travel, true, unit, upon, usually, voice, vowel, war, waves, whole, wind, wood, able, ago, am, among, ball, base, became, behind, boat, box, bring, brought, building, built, cannot, carefully, check, circle, class, clear, common, contain, correct, course, dark, decided, deep, done, dry, English, equation, explain, fact, feel, filled, finally, fine, fly, force, front, full, game, gave, government, green, half, heat, heavy, hot, inches, include, inside, island, known, language, less, machine, material, minutes, note, nothing, noun, object, ocean, oh, pair, person, plane, power, produce, quickly, ran, rest, road, round, rule, scientists, shape, shown, six, size, special, stars, stay, stood, street, strong, surface, system, ten, though, thousands, understand, verb, wait, warm, week, wheels, yes, yet";
    static public string L_fryFirstThousand = "about, all, an, and, are, as, at, be, been, but, by, called, can, come, could, day, did, do, down, each, find, first, for, from, get, go, had, has, have, he, her, him, his, how, if, in, into, is, it, like, long, look, made, make, many, may, more, my, no, not, now, number, of, oil, on, one, or, other, out, part, people, said, see, she, sit, so, some, than, that, the, their, them, then, there, these, they, this, time, to, two, up, use, was, water, way, we, were, what, when, which, who, will, with, words, would, write, you, your, after, again, air, also, America, animal, another, answer, any, around, ask, away, back, because, before, big, boy, came, change, different, does, end, even, follow, form, found, give, good, great, hand, help, here, home, house, just, kind, know, land, large, learn, letter, line, little, live, man, me, means, men, most, mother, move, much, must, name, need, new, off, old, only, our, over, page, picture, place, play, point, put, read, right, same, say, sentence, set, should, show, small, sound, spell, still, study, such, take, tell, things, think, three, through, too, try, turn, us, very, want, well, went, where, why, work, world, years, above, add, almost, along, always, began, begin, being, below, between, book, both, car, carry, children, city, close, country, cut, don’t, earth, eat, enough, every, example, eyes, face, family, far, father, feet, few, food, four, girl, got, group, grow, hard, head, hear, high, idea, important, Indian, it’s, keep, last, late, leave, left, let, life, light, list, might, mile, miss, mountains, near, never, next, night, often, once, open, own, paper, plant, real, river, run, saw, school, sea, second, seem, side, something, sometimes, song, soon, start, state, stop, story, talk, those, thought, together, took, tree, under, until, walk, watch, while, white, without, young, across, against, area, become, best, better, birds, black, body, certain, cold, color, complete, covered, cried, didn’t, dog, door, draw, during, early, easy, ever, fall, farm, fast, field, figure, fire, fish, five, friends, ground, happened, heard, himself, hold, horse, hours, however, hundred, I’ll, king, knew, listen, low, map, mark, measure, money, morning, music, north, notice, numeral, order, passed, pattern, piece, plan, problem, products, pulled, questions, reached, red, remember, rock, room, seen, several, ship, short, since, sing, slowly, south, space, stand, step, sun, sure, table, today, told, top, toward, town, travel, true, unit, upon, usually, voice, vowel, war, waves, whole, wind, wood, able, ago, am, among, ball, base, became, behind, boat, box, bring, brought, building, built, cannot, carefully, check, circle, class, clear, common, contain, correct, course, dark, decided, deep, done, dry, English, equation, explain, fact, feel, filled, finally, fine, fly, force, front, full, game, gave, government, green, half, heat, heavy, hot, inches, include, inside, island, known, language, less, machine, material, minutes, note, nothing, noun, object, ocean, oh, pair, person, plane, power, produce, quickly, ran, rest, road, round, rule, scientists, shape, shown, six, size, special, stars, stay, stood, street, strong, surface, system, ten, though, thousands, understand, verb, wait, warm, week, wheels, yes, yet, anything, arms, beautiful, believe, beside, bill, blue, brother, can’t, cause, cells, center, clothes, dance, describe, developed, difference, direction, discovered, distance, divided, drive, drop, edge, eggs, energy, Europe, exercise, farmers, felt, finished, flowers, forest, general, gone, grass, happy, heart, held, instruments, interest, job, kept, lay, legs, length, love, main, matter, meet, members, million, mind, months, moon, paint, paragraph, past, perhaps, picked, present, probably, race, rain, raised, ready, reason, record, region, represent, return, root, sat, shall, sign, simple, site, sky, soft, square, store, subject, suddenly, sum, summer, syllables, teacher, test, third, train, wall, weather, west, whether, wide, wild, window, winter, wish, written, act, Africa, age, already, although, amount, angle, appear, baby, bear, beat, bed, bottom, bright, broken, build, buy, care, case, cat, century, consonant, copy, couldn’t, count, cross, dictionary, died, dress, either, everyone, everything, exactly, factors, fight, fingers, floor, fraction, free, French, gold, hair, hill, hole, hope, ice, instead, iron, jumped, killed, lake, laughed, lead, let’s, lot, melody, metal, method, middle, milk, moment, nation, natural, outside, per, phrase, poor, possible, pounds, pushed, quiet, quite, remain, result, ride, rolled, sail, scale, section, sleep, smiled, snow, soil, solve, someone, son, speak, speed, spring, stone, surprise, tall, temperature, themselves, tiny, trip, type, village, within, wonder, alone, art, bad, bank, bit, break, brown, burning, business, captain, catch, caught, cents, child, choose, clean, climbed, cloud, coast, continued, control, cool, cost, decimal, desert, design, direct, drawing, ears, east, else, engine, England, equal, experiment, express, feeling, fell, flow, foot, garden, gas, glass, God, grew, history, human, hunting, increase, information, itself, joined, key, lady, law, least, lost, maybe, mouth, party, pay, period, plains, please, practice, president, received, report, ring, rise, row, save, seeds, sent, separate, serve, shouted, single, skin, statement, stick, straight, strange, students, suppose, symbols, team, touch, trouble, uncle, valley, visit, wear, whose, wire, woman, wrote, yard, you’re, yourself, addition, army, bell, belong, block, blood, blow, board, bones, branches, cattle, chief, compare, compound, consider, cook, corner, crops, crowd, current, doctor, dollars, eight, electric, elements, enjoy, entered, except, exciting, expect, famous, fit, flat, fruit, fun, guess, hat, hit, indicate, industry, insects, interesting, Japanese, lie, lifted, loud, major, mall, meat, mine, modern, movement, necessary, observe, park, particular, planets, poem, pole, position, process, property, provide, rather, rhythm, rich, safe, sand, science, sell, send, sense, seven, sharp, shoulder, sight, silent, soldiers, spot, spread, stream, string, suggested, supply, swim, terms, thick, thin, thus, tied, tone, trade, tube, value, wash, wasn’t, weight, wife, wings, won’t, action, actually, adjective, afraid, agreed, ahead, allow, apple, arrived, born, bought, British, capital, chance, chart, church, column, company, conditions, corn, cotton, cows, create, dead, deal, death, details, determine, difficult, division, doesn’t, effect, entire, especially, evening, experience, factories, fair, fear, fig, forward, France, fresh, Greek, gun, hoe, huge, isn’t, led, level, located, march, match, molecules, northern, nose, office, opposite, oxygen, plural, prepared, pretty, printed, radio, repeated, rope, rose, score, seat, settled, shoes, shop, similar, sir, sister, smell, solution, southern, steel, stretched, substances, suffix, sugar, tools, total, track, triangle, truck, underline, various, view, Washington, we’ll, western, win, women, workers, wouldn’t, wrong, yellow";
    static public string L_popularComputerGames = "Minecraft PlayerUnknown'sBattlegrounds DiabloIII WorldofWarcraft TheSims StarCraft Terraria Garry'sMod RollerCoasterTycoon3 Half-Life2 Half-Life CivilizationV TheSims3 GuildWars Myst TheSims2 StarCraftII TheForest Rust SimCity3000 GuildWars2 CitiesSkylines ARMA3 DiabloII EuroTruckSimulator2 Riven Populous RollerCoasterTycoon Warhammer40,000 Doom3 ThemePark AgeofEmpires CivilizationIV Command&Conquer Crysis DayZ EverQuest LifeIsStrange WarcraftIII StickfightTheGame CounterStrike Doom Magicka Anno1503 Anno1602 CossacksII Diablo FarCry 7DaystoDie Battlefield1942 TheWitcher2 CounterStrike TheWitcher Baldur'sGate AgeofEmpiresII TheBindingofIsaac Black&White CivilizationIII DoomII GrandTheftAutoV NeverwinterNights POD TheLastNinja SimCity SimCity4 Spore Stronghold WarcraftII TidesofDarkness Machinarium Quake Sacred DungeonSiege TiberianSun CrysisWarhead DukeNukem3D StarWarsGalaxies Stronghold Commandos TotalAnnihilation TheWitcher3 Battlefield Vietnam HarryPotter Psychonauts PrisonArchitect Warhammer CrusaderKingsII KillingFloor ZooTycoon AgeofMythology ArkSurvival Evolved Europa BioShock BladeRunner CivilizationII RedAlert2 TiberiumWars Cuphead SWAT DeerHunter Divinity DungeonLords EmpireEarth Factorio Frogger HeartsofIron Hidden&Dangerous HollowKnight JustSurvived FlightSimulator ColdWarCrisis PatricianIII PlanetCoaster QuakeII RailroadTycoon CastleWolfenstein StarWars RebelAssault StardewValley StanleyParable SupremeCommander Tropico Unreal UnrealTournament";
    static public string L_sportsWords = "aerobics archer archery arena arrow athlete athletics axel badminton ball base baseball basketball bat baton batter batting biathlon bicycle bicycling bike biking billiards bobsleigh bocce boomerang boules bow bowler bowling boxer boxing bronze medal bunt canoe canoeing catch catcher champion championship cleats club coach compete competing competition competitor crew cricket croquet cross country cue curling cycle cycling cyclist dart dartboard deadlifting decathlon defense diamond discus dive diver diving dodgeball doubleheader dugout equestrian equipment exercise fencing field field hockey fielder fielding figure skating fitness football forward free throw Frisbee game gear geocaching goal goalie gold medal golf golfer golfing guard gym gymnasium gymnast gymnastics halftime hammer throw handball hang gliding hardball helmet heptathlon high jump hitter hockey hole-in-one home home-plate home-run home-team hoop horseshoes huddle hurdle ice-hockey ice-rink ice-skates ice-skating infield infielder inline skates inning jai-alai javelin jog jogger judo jump jump rope jumper jumping karate kayak kayaker kayaking kickball kite kneepads kung fu lacrosse lawn bowling league long jump lose loser luge lutz major league mallet martial arts mat medal minor league mitt mouthguard move movement MVP net no-hitter Nordic skiing offense ollie Olympics orienteering out outfield outfielder paddle paddleball paddling paintball parasailing parkour pentathlon pickleball ping pong pitch pitcher play player playing playoffs pogo stick pole pole vault polo pool puck quarter quarterback quiver race racer racewalking racing racket racquetball rafting referee relay ride riding rink rock climbing roller skates roller skating row rower rowing rugby run runner running sailing score scoreboard scuba scull sculling shortstop shot put skate skating rink skeleton ski skier skiing slalom sled sledder sledding snorkeling snowboard snowboarder snowboarding snowshoeing soccer softball somersault speed skating sport sportsmanship squash stadium stick strike stroke Sumo wrestling surfer surfing swim swimmer swimming synchronized table tennis taekwondo tag target team teammate tee telemark skiing tennis tetherball throw throwing tie toboggan track and field trampoline triathlete triathlon triple jump triple play tug of war ultramarathon ultramarathoner umpire unicycle unicyclist uniform vault vaulter vaulting visiting team volley volley ball wakeboarding walk walker walking water polo water-ski water-skier water-skiing weightlifter weightlifting weights wetsuit white water rafting wicket win windsurfer windsurfing winner winning World Cup World Series wrestler wrestling";
    static public string L_piratesMedieval = "abandon adventure ahoy anchor armada arms asea ashore assault attack aye-aye bad bandanna bandit bandolier barbaric barrel battle beach behead boatswain bos'n bounty brawl brutal buccaneer cannon capsize captain capture cargo cave challenge chest coast coastline coins compass confiscate conquest contraband corpse corsair course crew criminal crook crow's-nest cruel curse cutlass cutthroat dagger danger daring dead deck deck hands desert-island dishonest doubloon earring escape evil explore eye patch fear fearsome ferocious fight first mate flag fleet fortune galleon gangplank gear gibbet gold greed gun gunner gunpowder haul heist high seas hijack hold hook horizon hostile hull hurricane ill-gotten illegal infamous island jetsam jewels Jolly-Roger keel keelhaul kidnap kill knife land land-ho landlubber lash lawless legend limey Long-John-Silver lookout loot lore lucre maggot malaria map marauder mariner maroon mast mates mayhem menace merchant musket mutiny nautical navigate New World notorious ocean old salt outcasts overboard parley parrot pegleg pieces-of-eight pillage pirate pistol plank plunder predatory privateer prowl quartermaster quarters quest raid ransack rat rations realm reckoning revenge revolt riches rigging roam rob robber rope rudder ruffian rum ruthless sabotage sail sailing sailor scalawag scar scurvy seas seaweed sextant ship shipmate shiver-me-timbers shore silver skiff skull-and-bones spoils steal swab-the-deck swagger swashbuckling sword thief thievery thug tides torture trade treachery treasure treasure-island truce unlawful unscrupulous vandalize vanquish vessel vicious vile villain violence violent walk-the-plank weapons yellow-fever yo-ho-ho archer aristocracy armor ballista baron baroness baronet bastion battering-ram battle-axe birthright castle catapult chain-mail chateau chieftain chivalry count countess court-jester crenelations crest crossbow crown crown-jewels curtain-wall donjon dragon drawbridge duchess duke dungeon dynasty earl empire feudal fort fortress gatehouse grand-duke great-hall heraldry hereditary highness honor imperial jester jousting keep king kingdom knight lady lady-in-waiting lance lord maid maiden mangonel manor manor-house marquis Middle-Ages moat monarch nobility noble onager palace peel-tower peer prince princess queen realm reign Renaissance royal royalty scepter serf shield siege sovereign sword titles tower trebuchet turret unicorn viscount wall watchtower";
    static public string L_xmasWords = "angel bells birth blizzard blustery boots bough bow box candle candy candy-cane cap card carolers caroling carols celebrate celebration ceremony charity chestnuts chill chilly chimney Christmas Christmas card Christmas carol Christmas Eve Christmas tree Christmas tree stand Christmastide cider coal cold cookie creche 25-Dec decorate decorations display eggnog elf elves eve evergreen exchange family family-reunion Father-Christmas feast Feliz-Navidad festival festive fir fireplace firewood frankincense frosty Frosty fruitcake garland gift gift-giving gingerbread gingerbread-house gingerbread-man gingerbread-woman give gold goodwill goose green greetings guest happy holiday holly hope hot-chocolate hot-cider hug ice-skates icicle icy ivy Jack-Frost Jesus jingle-bells jolly joy Noel joyful kings Krampus Kris-Kringle lights list log love manger merry Merry Christmas mince pie mistletoe mittens myrrh nativity naughty nice nippy Noel North-Pole nutcracker occasion ornaments package pageant parade partridge party pie pine-tree pinecone plum pudding poinsettia popcorn string presents receive red reindeer rejoice reunion ribbon ritual Rudolph Saint-Nicholas sales Santa Claus Santa's-elves Santa's-helpers Santa's-list Santa's-workshop scarf Scrooge season season's-greetings shopping skate sled sleigh sleigh-bells snow snowball snowbound snowfall snowflake snowman snowy socks spirit St-Nick star stocking stocking-stuffer sugarplum sweater tidings tinsel toboggan togetherness toy tradition tree trimming trips turkey unwrap vacation visit wassail winter wintertime wintry wise men wish wonder workshop wrap wrapping paper wreath Xmas yule yule-log yuletide";
    static public string L_Cobalt = "Cobalt CRM Dynamics Microsoft BusinessObject Cutlipped Regression Escalate SSO cutscope CobaltWill Sprint Consulting Support SquealScript Camsplain BoysClub MomsAgainstVape IIACall ScooterMeeting DevWalkout Coffee MagicClub GameJam FridayLunch JeffDonnyConfrontation CobaltSnacks Fogbugz BugzID cascade portal ISV WebElements API CompanyCulture CodeChange VimControversy Algorithm PeteTheYounger PeteTheElder WednesdayPizza NRDS rollout ReadyForDev DevComplete Triage ResolvedWon'tFix Bug CSS JacksPuns AlexIIAResetApp Backlog CoreBug Retrospective SprintPlanning ";


  }
}
