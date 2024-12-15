<script lang="ts">
    import type { PageData } from './$types';
    let CNPJ = $state("11111111111111");
    let CEP = $state("11111111");
    let Date = $state("1972-02-03");
    let QRCODE = $state("");

    let { data }: { data: PageData } = $props();
</script>

<h2 class="text-center mb-5 font-medium text-2xl">Register Material</h2>

<div class="w-full flex">
  <div class="w-1/2">
    <p>Selecione o fornecedor</p>
    <select class="select w-full max-w-xs">
      <option disabled selected>Pick your favorite Simpson</option>
      <option>Homer</option>
      <option>Marge</option>
      <option>Bart</option>
      <option>Lisa</option>
      <option>Maggie</option>
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
    <input bind:value={Date} type="date" class="input w-full max-w-xs" required/>
  </div>
  <div class="w-1/2 flex items-end">
    <button class="btn w-full btn-success" >
      Enviar
    </button>
  </div>
</div>