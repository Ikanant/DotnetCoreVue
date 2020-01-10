import Vue from 'vue'
import Router from 'vue-router'

import Hello from '@/components/Hello'
import AcronymRecords from '@/components/AcronymRecords'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Hello',
      component: Hello
    },
    {
      path: '/acronym-records',
      name: 'AcronymRecords',
      component: AcronymRecords
    }
  ]
})
