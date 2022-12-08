# Blazor Performance
I was curious about the performance of blazor compared to Vue 3 when I found this video on youtube https://www.youtube.com/watch?v=ijnTRW3HtTQ. So I tried to code the blazor by myself and I found out that blazor is almost the same or sometimes faster than Vue 3 in milliseconds against what was shown in the video. From what I see, The reason the blazor in the video is slow is because it uses MarkupString casting or conversion while the Vue example just simply adds inner HTML using v-html. Therefore, IMHO, the comparison is wrong. If I simply do the same by adding inner HTML in blazor and then blazor will render fast.

You can test it using this deployed version https://lively-stone-0416c4900.2.azurestaticapps.net/. Additional information this is hosted as static web app meaning that the speed will depend on your computer's speed. At startup, the blazor will download the files in your browser and after that, the processing will be already handled by your computer hardware.

### Vue 3 vs Blazor execution time
![image](https://user-images.githubusercontent.com/20876086/206347841-288326d5-472c-473c-86cb-b73fa26e1755.png)

The purpose of this project is to gain more knowledge about the different frameworks so we could choose what to use in developing web apps. This is not attacking a person, OK! :)
