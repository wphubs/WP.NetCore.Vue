<template>
    <div style="width: 100%;background:#ededed;min-height: calc(100vh - 200px); ">
      <el-row :gutter="10">
        <el-col :xs="{span: 22, offset: 1}" :sm="{span: 22, offset: 1}" :md="{span: 14, offset: 5}"
            :lg="{span: 14, offset: 5}" :xl="{span: 14, offset:5}">
          <div style="padding: 20px 0px;">
            <el-page-header @back="goBack" content="详情">
            </el-page-header>
          </div>
          <el-card style="margin-top: 20px;" >
            <div slot="header" >
              <div class="title">【{{articleData.ClassName}}】{{articleData.Title}} </div>
            </div>
            <div  >
              <div class="detail-body" v-html="markData"></div>     
            </div>
          </el-card>

        </el-col>
    </el-row>
    </div>
  </template>
   
  <script> 
    import axios from 'axios'
    import marked from 'marked'
    import highlight from 'highlight.js/lib/highlight'
import javascript from 'highlight.js/lib/languages/javascript'
import css from 'highlight.js/lib/languages/css'
import php from 'highlight.js/lib/languages/php'
import python from 'highlight.js/lib/languages/python'
import sql from 'highlight.js/lib/languages/sql'
import bash from 'highlight.js/lib/languages/bash'
    
highlight.registerLanguage('javascript', javascript)
highlight.registerLanguage('css', css)
highlight.registerLanguage('php', php)
highlight.registerLanguage('python', python)
highlight.registerLanguage('sql', sql)
highlight.registerLanguage('bash', bash)

    export default {
      data() {
        return {
  
        }
      },
      methods: {
        goBack() {
          history.go(-1)
      }
      },
      async asyncData({ params,$config}) {
        var { id } = params;
        var {data} = await axios.get(`${$config.baseURL}Article/GetArticleInfo?articleId=`+id)
        marked.setOptions({
        renderer: new marked.Renderer(),
        gfm: true,
        tables: true,
        breaks: false,
        pedantic: false,
        sanitize: false,
        smartLists: true,
        smartypants: false,
        highlight: function(code, lang) {
          return highlight.highlightAuto(code).value
        }
      })
        const markHtml = marked(data.Content)
        return { articleData: data,markData:markHtml}
      },
      mounted() {
      
      },
    }
  </script>
  
  <style>
    
    .detail-body ul {
      list-style:disc;
        line-height: 35px;
        margin: 20px 0px 20px 20px;
    }
    .detail-body p {
      padding: 20px 0px;
    }
  </style>
  <style scoped>
  .title{
      font-size: 18px;
      font-weight: 600;
      margin-left: 20px;

    }


.detail-body {
  text-align: left;
  color: #666;
  padding: 22px;
  padding-bottom: 10px;
  min-height: 500px;
 
}
ul {list-style-type:circle;}

  </>