# Celestial Cats: Step-by-Step Execution Checklist

## 0) Read first
- [ ] I understand this guide assumes no Unity experience, Windows-only, and sparing paid assets.
- [ ] I will keep scope small: ship MVP without microtransactions, add paid currency later if needed.

## 1) Environment setup (one-time)
- [ ] Install Unity Hub.
- [ ] Install latest Unity LTS with 2D template support.
- [ ] Install Visual Studio with Unity workload.
- [ ] Install Git and enable Git LFS.
- [ ] Create Git repo with Unity `.gitignore` and `.gitattributes` for LFS.

## 2) Create the Unity project
- [ ] Unity Hub → New Project → 2D Core.
- [ ] Name it CelestialCats and set location.
- [ ] Open project and confirm Editor launches.
- [ ] Create folders: `Assets/Art`, `Assets/Audio`, `Assets/Data`, `Assets/Systems`, `Assets/UI`.
- [ ] Add TextMeshPro essentials.

## 3) Build the first playable loop
- [ ] Create a Canvas and single UI screen.
- [ ] Add a Harmony counter and Align Orbit button.
- [ ] Add a script to increment Harmony on click.
- [ ] Save and load Harmony with PlayerPrefs.
- [ ] Quit and relaunch to confirm persistence.

## 4) Add data-driven cats (ScriptableObjects)
- [ ] Create Cat ScriptableObject: name, baseProduction, cost, growth.
- [ ] Make 2 cat assets in `Assets/Data`.
- [ ] Create CatSystem to load data and tick production.
- [ ] Display cats and levels on UI.
- [ ] Add Upgrade button per cat and apply cost scaling.

## 5) Add planets and multipliers
- [ ] Create Planet ScriptableObject: stability, multiplier.
- [ ] Add 2 planet assets.
- [ ] Multiply cat output by planet stability.
- [ ] Add planet upgrade button and cost scaling.

## 6) Offline progress (critical MVP feature)
- [ ] Save timestamp and production rate on quit.
- [ ] Compute elapsed time on load.
- [ ] Apply offline multiplier and cap rules.
- [ ] Show offline gains popup.

## 7) Achievements that boost production
- [ ] Create Achievement ScriptableObject: trigger, reward.
- [ ] Implement a global boost applied to production.
- [ ] Add 6 meme achievements.
- [ ] Add unlock notification UI.

## 8) Add progression and prestige
- [ ] Add Stardust currency.
- [ ] Implement Prestige reset converting Harmony to Stardust.
- [ ] Apply Stardust global multiplier.
- [ ] Add Prestige button and confirmation UI.

## 9) UI flow and screens
- [ ] Add navigation tabs for Main, Upgrades, Constellations, Prestige, Shop, Achievements.
- [ ] Use simple layout first, polish later.
- [ ] Ensure each screen is reachable from Main in one click.

## 10) Integrate Steam (account + build pipeline)
- [ ] Create Steamworks account and pay app fee.
- [ ] Create app and configure depots.
- [ ] Install Steamworks SDK and set up build scripts.
- [ ] Build Windows version from Unity.
- [ ] Upload to Steam beta branch and test.

## 11) Steam achievements
- [ ] Add Steamworks.NET.
- [ ] Create achievement IDs in Steamworks.
- [ ] Map in-game achievements to Steam IDs.
- [ ] Test unlocking achievements on beta branch.

## 12) Monetization path for Steam
- [ ] Launch MVP without paid currency.
- [ ] Use cosmetic DLC or supporter pack to validate revenue.
- [ ] If adding paid currency later, plan secure server verification.

## 13) Unity Asset Store usage
- [ ] Buy only bottleneck assets: UI kit, icon pack, simple cat sprites.
- [ ] Verify license allows commercial use.
- [ ] Maintain asset/license spreadsheet.
- [ ] Avoid large frameworks you cannot maintain.

## 14) Quality bar checklist
- [ ] UI readable at 1080p and 1440p.
- [ ] No hard crashes after 2 hours idle.
- [ ] Offline progress never exceeds cap.
- [ ] Save data is versioned.

## 15) First public demo
- [ ] Cut content to smallest fun loop.
- [ ] Add one meme event and one legendary cat.
- [ ] Release demo build on Steam.
- [ ] Collect feedback and iterate.

## Related docs
- [`plans/celestial-cats-mvp-design.md`](plans/celestial-cats-mvp-design.md)
- [`plans/celestial-cats-execution-plan.md`](plans/celestial-cats-execution-plan.md)
