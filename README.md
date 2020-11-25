# Unity Auto Questionnaire
This will allow Unity games to open a questionnaire with ID automatically.

This example uses **google forms** as the questionnaire tool of choice. Look up URL parameters for your own tools to check implimentation, although this is paid for with many tools I found.



## To do this:

# Questionnaire Setup [Google Forms]:

1. Create your form as usual to your liking

2. Create a new short text question at the beginning or end - we'll call it ID. You could also put this in a seperate section
   Note: Do not allow users to skip this section if you create one, forms will not record the ID.

3. Go to the top and click the three dots icon, then click 'Get pre-filled link'.

4. Find the ID question and put anything in the text box, I put 'THIS'. Click 'Get Link' then copy it. you will get this:
   forms/d/e/1FAIpQLSfutmvWX2NzKnRHnjO4H8R4_Zat_tISDhEK5cZL3BkkNi-bZg/viewform?usp=pp_url&entry.315461126=**THIS**
   
5. This is your URL. Delete everything after the final equals sign, this is where you put what you'll pre-populate the answer with




# Unity Setup:


1. The Unity code should be placed in your 'end game state' e.g. 
      if (gameFinished == true){
           //do it here
            }
   All that's needed is the single line to open the URL.
         
2. If you're collecting any other data then ensure that the deviceUniqueIdentifier is uploaded to the server(see https://github.com/francescosoave/unity-server-upload to set this up) - this will mean you can link plays with answers.

3. Edit the URL in the single line to direct to your form - see the above section

4. Launch your game to see if this works - use the start code example for simplicity

You will end up with a pre-populated link depending on their ID. Here is what the google form looks like

**not prefilled**
https://docs.google.com/forms/d/e/1FAIpQLSfutmvWX2NzKnRHnjO4H8R4_Zat_tISDhEK5cZL3BkkNi-bZg/viewform

**prefilled question**
https://docs.google.com/forms/d/e/1FAIpQLSfutmvWX2NzKnRHnjO4H8R4_Zat_tISDhEK5cZL3BkkNi-bZg/viewform?entry.315461126=1234567891012345678
