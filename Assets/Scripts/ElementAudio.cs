using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementAudio : MonoBehaviour

{
    public AudioSource audioSource;

    // Add audio clips for each element (Hydrogen to Radon, excluding specified elements)
    public AudioClip hydrogenClip, heliumClip, lithiumClip, berylliumClip, boronClip, carbonClip, nitrogenClip, oxygenClip,
                     fluorineClip, neonClip, sodiumClip, magnesiumClip, aluminumClip, siliconClip, phosphorusClip,
                     sulfurClip, chlorineClip, argonClip, potassiumClip, calciumClip, scandiumClip, titaniumClip,
                     vanadiumClip, chromiumClip, manganeseClip, ironClip, cobaltClip, nickelClip, copperClip, zincClip,
                     galliumClip, germaniumClip, arsenicClip, seleniumClip, bromineClip, kryptonClip, rubidiumClip,
                     strontiumClip, yttriumClip, zirconiumClip, niobiumClip, molybdenumClip, technetiumClip, rutheniumClip,
                     rhodiumClip, palladiumClip, silverClip, cadmiumClip, indiumClip, tinClip, antimonyClip, telluriumClip,
                     iodineClip, xenonClip, cesiumClip, bariumClip, lanthanumClip, hafniumClip, tantalumClip, tungstenClip,
                     rheniumClip, osmiumClip, iridiumClip, platinumClip, goldClip, mercuryClip, thalliumClip, leadClip,
                     bismuthClip, poloniumClip, astatineClip, radonClip;

    // Add buttons for each element
    public Button hydrogenButton, heliumButton, lithiumButton, berylliumButton, boronButton, carbonButton, nitrogenButton, oxygenButton,
                  fluorineButton, neonButton, sodiumButton, magnesiumButton, aluminumButton, siliconButton, phosphorusButton,
                  sulfurButton, chlorineButton, argonButton, potassiumButton, calciumButton, scandiumButton, titaniumButton,
                  vanadiumButton, chromiumButton, manganeseButton, ironButton, cobaltButton, nickelButton, copperButton, zincButton,
                  galliumButton, germaniumButton, arsenicButton, seleniumButton, bromineButton, kryptonButton, rubidiumButton,
                  strontiumButton, yttriumButton, zirconiumButton, niobiumButton, molybdenumButton, technetiumButton, rutheniumButton,
                  rhodiumButton, palladiumButton, silverButton, cadmiumButton, indiumButton, tinButton, antimonyButton, telluriumButton,
                  iodineButton, xenonButton, cesiumButton, bariumButton, lanthanumButton, hafniumButton, tantalumButton, tungstenButton,
                  rheniumButton, osmiumButton, iridiumButton, platinumButton, goldButton, mercuryButton, thalliumButton, leadButton,
                  bismuthButton, poloniumButton, astatineButton, radonButton;

    void Start()
    {
        // Add listeners for each button
        hydrogenButton.onClick.AddListener(() => PlayAudio(hydrogenClip));
        heliumButton.onClick.AddListener(() => PlayAudio(heliumClip));
        lithiumButton.onClick.AddListener(() => PlayAudio(lithiumClip));
        berylliumButton.onClick.AddListener(() => PlayAudio(berylliumClip));
        boronButton.onClick.AddListener(() => PlayAudio(boronClip));
        carbonButton.onClick.AddListener(() => PlayAudio(carbonClip));
        nitrogenButton.onClick.AddListener(() => PlayAudio(nitrogenClip));
        oxygenButton.onClick.AddListener(() => PlayAudio(oxygenClip));
        fluorineButton.onClick.AddListener(() => PlayAudio(fluorineClip));
        neonButton.onClick.AddListener(() => PlayAudio(neonClip));
        sodiumButton.onClick.AddListener(() => PlayAudio(sodiumClip));
        magnesiumButton.onClick.AddListener(() => PlayAudio(magnesiumClip));
        aluminumButton.onClick.AddListener(() => PlayAudio(aluminumClip));
        siliconButton.onClick.AddListener(() => PlayAudio(siliconClip));
        phosphorusButton.onClick.AddListener(() => PlayAudio(phosphorusClip));
        sulfurButton.onClick.AddListener(() => PlayAudio(sulfurClip));
        chlorineButton.onClick.AddListener(() => PlayAudio(chlorineClip));
        argonButton.onClick.AddListener(() => PlayAudio(argonClip));
        potassiumButton.onClick.AddListener(() => PlayAudio(potassiumClip));
        calciumButton.onClick.AddListener(() => PlayAudio(calciumClip));
        scandiumButton.onClick.AddListener(() => PlayAudio(scandiumClip));
        titaniumButton.onClick.AddListener(() => PlayAudio(titaniumClip));
        vanadiumButton.onClick.AddListener(() => PlayAudio(vanadiumClip));
        chromiumButton.onClick.AddListener(() => PlayAudio(chromiumClip));
        manganeseButton.onClick.AddListener(() => PlayAudio(manganeseClip));
        ironButton.onClick.AddListener(() => PlayAudio(ironClip));
        cobaltButton.onClick.AddListener(() => PlayAudio(cobaltClip));
        nickelButton.onClick.AddListener(() => PlayAudio(nickelClip));
        copperButton.onClick.AddListener(() => PlayAudio(copperClip));
        zincButton.onClick.AddListener(() => PlayAudio(zincClip));
        galliumButton.onClick.AddListener(() => PlayAudio(galliumClip));
        germaniumButton.onClick.AddListener(() => PlayAudio(germaniumClip));
        arsenicButton.onClick.AddListener(() => PlayAudio(arsenicClip));
        seleniumButton.onClick.AddListener(() => PlayAudio(seleniumClip));
        bromineButton.onClick.AddListener(() => PlayAudio(bromineClip));
        kryptonButton.onClick.AddListener(() => PlayAudio(kryptonClip));
        rubidiumButton.onClick.AddListener(() => PlayAudio(rubidiumClip));
        strontiumButton.onClick.AddListener(() => PlayAudio(strontiumClip));
        yttriumButton.onClick.AddListener(() => PlayAudio(yttriumClip));
        zirconiumButton.onClick.AddListener(() => PlayAudio(zirconiumClip));
        niobiumButton.onClick.AddListener(() => PlayAudio(niobiumClip));
        molybdenumButton.onClick.AddListener(() => PlayAudio(molybdenumClip));
        technetiumButton.onClick.AddListener(() => PlayAudio(technetiumClip));
        rutheniumButton.onClick.AddListener(() => PlayAudio(rutheniumClip));
        rhodiumButton.onClick.AddListener(() => PlayAudio(rhodiumClip));
        palladiumButton.onClick.AddListener(() => PlayAudio(palladiumClip));
        silverButton.onClick.AddListener(() => PlayAudio(silverClip));
        cadmiumButton.onClick.AddListener(() => PlayAudio(cadmiumClip));
        indiumButton.onClick.AddListener(() => PlayAudio(indiumClip));
        tinButton.onClick.AddListener(() => PlayAudio(tinClip));
        antimonyButton.onClick.AddListener(() => PlayAudio(antimonyClip));
        telluriumButton.onClick.AddListener(() => PlayAudio(telluriumClip));
        iodineButton.onClick.AddListener(() => PlayAudio(iodineClip));
        xenonButton.onClick.AddListener(() => PlayAudio(xenonClip));
        cesiumButton.onClick.AddListener(() => PlayAudio(cesiumClip));
        bariumButton.onClick.AddListener(() => PlayAudio(bariumClip));
        lanthanumButton.onClick.AddListener(() => PlayAudio(lanthanumClip));
        hafniumButton.onClick.AddListener(() => PlayAudio(hafniumClip));
        tantalumButton.onClick.AddListener(() => PlayAudio(tantalumClip));
        tungstenButton.onClick.AddListener(() => PlayAudio(tungstenClip));
        rheniumButton.onClick.AddListener(() => PlayAudio(rheniumClip));
        osmiumButton.onClick.AddListener(() => PlayAudio(osmiumClip));
        iridiumButton.onClick.AddListener(() => PlayAudio(iridiumClip));
        platinumButton.onClick.AddListener(() => PlayAudio(platinumClip));
        goldButton.onClick.AddListener(() => PlayAudio(goldClip));
        mercuryButton.onClick.AddListener(() => PlayAudio(mercuryClip));
        thalliumButton.onClick.AddListener(() => PlayAudio(thalliumClip));
        leadButton.onClick.AddListener(() => PlayAudio(leadClip));
        bismuthButton.onClick.AddListener(() => PlayAudio(bismuthClip));
        poloniumButton.onClick.AddListener(() => PlayAudio(poloniumClip));
        astatineButton.onClick.AddListener(() => PlayAudio(astatineClip));
        radonButton.onClick.AddListener(() => PlayAudio(radonClip));
    }

    void PlayAudio(AudioClip clip)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        audioSource.clip = clip;
        audioSource.Play();
    }
}

