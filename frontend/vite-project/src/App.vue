<script setup>
import { onMounted, ref } from 'vue'
import axios from 'axios'

const posts = ref([])
const loading = ref(true)

onMounted(async () => {
  try {
    const response = await axios.get('https://jsonplaceholder.typicode.com/posts')
    posts.value = response.data
    console.log('Fetched posts:', posts.value)
  } catch (error) {
    console.error('Error fetching posts:', error)
  }
  finally {
    loading.value = false
  }
})
</script>

<template>
  <pre class="json">
  {{ JSON.stringify(posts, null, 2) }}
  </pre>
</template>

<style>
.json {
white-space: pre-wrap;
word-break: break-word;
font-family: monospace;
padding: 16px;
border-radius: 8px;
max-width: 100%;
overflow-x: auto;
}
</style>
