<template>
  <div class="hello">
	<h1>{{ title }}</h1>
	<h2>Making sense of all these acronyms</h2>
  </div>
</template>

<script>
export default {
  data () {
	  return {
  	  title: 'Acronym Professional Parser Limited Edition'
	  }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1, h2 {
  font-weight: normal;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: inline-block;
  margin: 0 10px;
}

a {
  color: #35495E;
}
</style>
