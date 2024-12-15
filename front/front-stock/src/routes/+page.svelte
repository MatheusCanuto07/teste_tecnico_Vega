<script>
// @ts-nocheck

	import { onMount } from "svelte";

  let data = $state([]);
  onMount(async () => {
    fetch("http://localhost:5266/api/v1/material")
    .then(response => response.json())
    .then(dados => {
      console.log(dados);
      data = dados;
    }).catch(error => {
      console.log(error);
      return [];
    });
  });
</script>

<div class="container-lg px-10">
  <div>
    <h1>Teste</h1>
    {JSON.stringify(data, null)}
  </div>
</div>


