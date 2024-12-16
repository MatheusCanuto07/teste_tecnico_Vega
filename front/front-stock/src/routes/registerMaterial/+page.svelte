<script lang="ts">
  import { onMount } from 'svelte';
  let QRCODE = $state("");
  let supplier = $state([]);
  let selectHTML : HTMLSelectElement | null = $state(null);
  let supplierSelected = "";
  
  onMount(async () => {
    fetch("http://localhost:5266/api/v1/supplier")
    .then(response => response.json())
    .then(dados => {
      supplier = dados;
      console.log(dados);
    }).catch(error => {
      console.log(error);
      return [];
    });
  })
  
  function loadQRCODE(selectId){
    console.log(selectId)
    let aux = $state.snapshot(supplier).find(element => element.id === selectId);
    QRCODE = aux.qrCode.replace(/%([^%]+)%/g, '$1');
    //supplierSelected = supplier.qrCode.replace(/%([^%]+)%/g, '$1');
  } 

  let { data }: { data: ImageData } = $props();
</script>

<h2 class="text-center mb-5 font-medium text-2xl">Register Material</h2>

<div class="w-full flex">
  <div class="w-1/2">
    <p>Selecione o fornecedor</p>
    <select bind:value={selectHTML} onchange={() => loadQRCODE(selectHTML)} class="select w-full max-w-xs">
      <option disabled selected>Selecione um fornecedor</option>
      {#each supplier as s}
      <option value={s.id}>{s.name}</option>
      {/each}
    </select>
  </div>
  <div class="w-1/2">
    <p>QRCODE</p>
    {QRCODE !== "" ? QRCODE : ""}
  </div>
</div>

<div class="w-full flex mt-3">
  <div class="w-1/2">
    <p>Select the registration date</p>
    <input type="date" class="input w-full max-w-xs" required/>
  </div>
  <div class="w-1/2 flex items-end">
    <button class="btn w-full btn-success" >
      Enviar
    </button>
  </div>
</div>