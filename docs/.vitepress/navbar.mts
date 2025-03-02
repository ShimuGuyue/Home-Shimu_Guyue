import { DefaultTheme } from 'vitepress';

// 定义导航栏配置
export const nav: DefaultTheme.NavItem[] = [
    {
        text: '首页',
        link: '/' // 表示docs/index.md
    },
    {
        text: '收藏夹',
        link: '/收藏夹/'
    },
    {
        text: '学习笔记',
        items: [
            {
                text: '编程语言',
                link: '/学习笔记/编程语言/'
            },
            {
                text: '算法和数据结构',
                link: '/学习笔记/算法和数据结构/'
            }
        ]
    }
];