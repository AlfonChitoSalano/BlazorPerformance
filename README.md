# Blazor Performance
I was curious about the performance of blazor compared to Vue 3 when I found this video on youtube https://www.youtube.com/watch?v=ijnTRW3HtTQ. So I tried to code the blazor by myself and I found out that blazor is faster than Vue 3 in milliseconds against what was shown in the video. The reason the blazor in the video is slow is because it uses MarkupString casting or conversion while the Vue example just simply adds inner HTML using v-html. Therefore, IMHO, the comparison is wrong. If I simply do the same by adding inner HTML in blazor and the blazor will render faster.

The purpose of this project is to gain more knowledge about different frameworks so we could what to use in developing web apps. This is not attacking a person, OK! :)
