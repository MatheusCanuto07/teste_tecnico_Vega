<script lang="ts">
	import Nav from '$lib/components/Nav.svelte';
	import '../app.css';
	let { children } = $props();
</script>

<Nav />

<div class="mx-20">
  {@render children()}
</div>
