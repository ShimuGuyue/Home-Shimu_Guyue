import { defineConfig } from 'vitepress'
import { nav } from './navbar.mts';  // 导入导航栏配置

// https://vitepress.dev/reference/site-config

export default defineConfig({
  title: "石木古月的温馨小窝",  // 项目标题

  // description: "A VitePress Site",  // 项目描述

  themeConfig: {
    // https://vitepress.dev/reference/default-theme-config

    logo: '/images/logo.png',  // 项目Logo

    nav: nav,  // 导航栏配置

    sidebar: [
      {
        text: 'Examples',  // 侧边栏标题
        items: [
          { text: 'Markdown Examples', link: '/markdown-examples' },  // 侧边栏Markdown示例链接
          { text: 'Runtime API Examples', link: '/api-examples' }  // 侧边栏API示例链接
        ]
      }
    ],

    socialLinks: [
      { icon: 'bilibili', link: 'https://space.bilibili.com/490341270' },
      { icon: 'github', link: 'https://github.com/ShimuGuyue' },
    ]
  }
})
