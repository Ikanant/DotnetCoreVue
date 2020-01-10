<template>
  <div class="home">
    <div>
      <b-jumbotron>
        <template v-slot:header>
          <img src="./../assets/logo.png" width="80"/>
          <span>{{title}}</span>
        </template>
        <template v-slot:lead>{{description}}</template>
        <hr class="my-4">

        <p>{{instructionMessage}}</p>

        <div>
          <b-button variant="info" to="/acronym-records">Search by Word</b-button>
          <b-button :class="{disabled: true}" variant="info" to="/">Search by Paragraph</b-button>
          <b-button variant="outline-info" v-if="adminMode" to="/acronym-editor">Acronym Editor</b-button>
        </div>
      </b-jumbotron>
    </div>
  </div>
</template>

<script>
export default {
  data () {
	  return {
      title: 'A-P-P-L-E',
      description: `This is a simple (VUE + ASP.NET) application intended help anyone seeking to understand
                    any ACRONYM commonly used throughout our company while learning a thing or two about Vue.js`,
      instructionMessage: 'Please select tool:',
      adminMode: true
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
</style>
