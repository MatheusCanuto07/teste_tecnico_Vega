<script lang="ts">
    import type { PageData } from './$types';
    let CNPJ = $state("11111111111111");
    let CEP = $state("11111111");
    let Date = $state("1972-02-03");

    $inspect(CNPJ, CEP, Date);

    function submit(){
      if(CNPJ !== "" && CNPJ.length == 14 && CEP !== "" && CEP.length == 8 && Date !== ""){
        let string = `${CNPJ}%${CEP}%${Date}`;
        console.log(string)
      } else{
        alert("Dados inválidos");
      }
    }

    let { data }: { data: PageData } = $props();
</script>

<h1 class="text-center mb-5 font-medium text-2xl">Register Supplier</h1>

<div class="w-full flex">
  <div class="w-1/2">
    <p>Enter your CNPJ:</p>
    <input bind:value={CNPJ} type="text" placeholder="Type here" class="input w-full max-w-xs" required/>
  </div>
  <div class="w-1/2">
    <p>Enter your CEP:</p>
    <input bind:value={CEP} type="text" placeholder="Type here" class="input w-full max-w-xs" required/>
  </div>
</div>

<div class="w-full flex mt-3">
  <div class="w-1/2">
    <p>Select the registration date</p>
    <input bind:value={Date} type="date" class="input w-full max-w-xs" required/>
  </div>
  <div class="w-1/2 flex items-end">
    <button class="btn w-full btn-success" onclick={submit}>
      Enviar
    </button>
  </div>
</div>
