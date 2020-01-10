import Vue from 'vue'
import Router from 'vue-router'

import Home from '@/components/Home'
import AcronymEditor from '@/components/AcronymEditor'
import SearchByWord from '@/components/SearchByWord'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/acronym-editor',
      name: 'AcronymEditor',
      component: AcronymEditor
    },
    {
      path: '/search-by-word',
      name: 'SearchByWord',
      component: SearchByWord
    }
  ]
})
