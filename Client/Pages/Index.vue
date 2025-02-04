<script setup lang="ts">
import {Head, usePage} from '@inertiajs/vue3'

const page = usePage<{
  message: string
}>()

</script>

<template>
<Head title="Welcome"></Head>
<h1>{{ page.props.message }} </h1>
</template>

<style scoped>

</style>